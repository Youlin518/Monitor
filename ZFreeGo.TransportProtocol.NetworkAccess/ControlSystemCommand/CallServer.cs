﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ZFreeGo.TransmissionProtocol.NetworkAccess104.ApplicationMessage;
using ZFreeGo.TransmissionProtocol.NetworkAccess104.BasicElement;
using ZFreeGo.TransmissionProtocol.NetworkAccess104.ConstructionElement;
using ZFreeGo.TransportProtocol.NetworkAccess.Helper;

namespace ZFreeGo.TransmissionProtocol.NetworkAccess104.ControlSystemCommand
{
    /// <summary>
    /// 召唤服务
    /// </summary>
    public class CallServer : ReciveSendServer<ControlProcessASDU>
    {
        /// <summary>
        /// 召唤服务事件
        /// </summary>
        public event EventHandler<CallEventArgs> ServerEvent;

        /// <summary>
        /// 召唤帧信息
        /// </summary>
        ControlProcessASDU mSendFrame;

        /// <summary>
        /// 接收帧
        /// </summary>
        ControlProcessASDU mReciveFrame;

        /// <summary>
        /// 发送数据委托
        /// </summary>
        Func<ControlProcessASDU, bool> mSendDataDelegate;

        /// <summary>
        /// 取消发送标志
        /// </summary>
        private bool cancelSend;

       /// <summary>
       /// 召唤服务启动服务
       /// </summary>
       /// <param name="sendDataDelegate">发送委托</param>
       /// <param name="cot">传输原因</param>
       /// <param name="qoi">传输限定词</param>
        public void StartServer(Func<ControlProcessASDU, bool> sendDataDelegate, CauseOfTransmissionList cot, QualifyOfInterrogationList qoi)
        {
            try
            {
                InitData();
                mReadThread = new Thread(ReciveThread);
                mReadThread.Priority = ThreadPriority.Normal;
                mReadThread.Name = "ReciveThread线程数据";
                mReadThread.Start();

                mServerThread = new Thread(ServerThread);
                mServerThread.Priority = ThreadPriority.Normal;
                mServerThread.Name = "ServerThread线程";
                mServerThread.Start();
                serverState = true;

                mSendDataDelegate = sendDataDelegate;
                var id = TypeIdentification.C_IC_NA_1;//召唤命令               
                mSendFrame = new ControlProcessASDU(id, cot, 0, qoi);

                cancelSend = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <returns>true-成功，false-失败，终止线程</returns>
        public override bool TransmitData()
        {
            if (cancelSend)
            {
                return true;
            }
            else
            {
                bool state =  mSendDataDelegate(mSendFrame);
                if (!state)
                {
                    SendEvent("发送失败，终止处理。", ControlSystemServerResut.SendFault);
                }
                return state; 
            }
        }

        /// <summary>
        /// 检测接收数据, Todo::没有实现检测,直接提取
        /// </summary>
        /// <returns>true--检测通过，false--检测失败</returns>
        public override bool CheckData()
        {
            try
            {
                if (mReciveQuene.Count > 0)
                {
                    mReciveFrame = mReciveQuene.Dequeue();                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 准时应答后相应的事件
        /// </summary>
        /// <returns>true--正常执行，false--结束执行，终止当前线程</returns>
        public override bool AckOnTime()
        {
            try
            {
                switch ((CauseOfTransmissionList)mReciveFrame.CauseOfTransmission1)
                {
                    case CauseOfTransmissionList.ActivationACK:
                        {
                            cancelSend = true;//取消下次发送仅仅等待
                            SendEvent("召唤激活确认", ControlSystemServerResut.AcvtivityAck);
                            mRepeatCount = 0;
                            return true;
                        }
                    case CauseOfTransmissionList.ActivateTermination:
                        {
                            SendEvent("召唤激活终止", ControlSystemServerResut.ActivateTermination);
                            mRepeatCount = 0;
                            return false;//终止循环
                        }
                    default:
                        {
                            SendEvent("未识别的ID", ControlSystemServerResut.Unknow);
                            return false;
                        }
                }
            }
            catch (Exception ex)
            {
                SendEvent(ex.Message, ControlSystemServerResut.Error);
                StopServer();
                return false;
            }
        }


        /// <summary>
        /// 超时后执行事件
        /// </summary>
        /// <returns>true--继续，fals--终止</returns>
        public override bool AckOverTime()
        {
            if(++mRepeatCount < mRepeatMaxCount)
            {
                cancelSend = false;
                SendEvent(string.Format("应答超时,进行第{0}次重试.", mRepeatCount), ControlSystemServerResut.OverTime);
                return true;
            }
            else
            {
                SendEvent(string.Format("重试失败，结束召唤。", mRepeatCount), ControlSystemServerResut.Fault);
                return false;
            }
        }


        /// <summary>
        /// 发送事件
        /// </summary>
        /// <param name="comment">注释</param>
        /// <param name="result">结果</param>
        public void SendEvent(string comment, ControlSystemServerResut result)
        {
            if ( ServerEvent != null)
            {
                ServerEvent(Thread.CurrentThread, new CallEventArgs(comment, result));
            }
        }


    }
}