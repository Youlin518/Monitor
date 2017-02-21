﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using ZFreeGo.Monitor.DASModel.GetViewData;
using ZFreeGo.Monitor.DASModel.DataItemSet;
using ZFreeGo.TransmissionProtocols;
using ZFreeGo.TransmissionProtocols.ControlProcessInformation;
using System;
using ZFreeGo.TransmissionProtocols.TransmissionControl104;
using ZFreeGo.TransmissionProtocols.BasicElement;
using ZFreeGo.TransmissionProtocols.Frame104;
using System.Collections.Generic;

namespace ZFreeGo.Monitor.DASDock.ViewModel
{

    public class ProtectSetpointViewModel : ViewModelBase
    {
    
        private SetPointServer setPointServer;

        /// <summary>
        /// Initializes a new instance of the DataGridPageViewModel class.
        /// </summary>
        public ProtectSetpointViewModel()
        {
            _userData = new ObservableCollection<ProtectSetPoint>();
            LoadDataCommand = new RelayCommand(ExecuteLoadDataCommand);
            Messenger.Default.Register<MonitorViewData>(this, "LoadData", ExecuteLoadData);
            Messenger.Default.Register<NetWorkProtocolServer>(this, "NetWorkProtocolServer", ExecuteNetWorkProtocolServer);
            SetProtectPoint = new RelayCommand<string>(ExecuteSetPreotectPoint);
        }


        private void ExecuteNetWorkProtocolServer(NetWorkProtocolServer obj)
        {
           if(obj != null)
           {
               setPointServer = obj.SetPointServer;
           }
        }

        private void ExecuteLoadData(MonitorViewData obj)
        {
            if (obj != null)
            {
                UserData = obj.GetProtectSetPointList();
            }
        }

        /************** 属性 **************/
        private ObservableCollection<ProtectSetPoint> _userData;
        /// <summary>
        /// 用户信息数据
        /// </summary>
        public ObservableCollection<ProtectSetPoint> UserData
        {
            get { return _userData; }
            set
            {
                _userData = value;
                RaisePropertyChanged("UserData");
            }
        }
        #region 加载数据命令：LoadDataCommand
        /// <summary>
        /// 加载数据
        /// </summary>
        public RelayCommand LoadDataCommand { get; private set; }

        //加载用户数据
        void ExecuteLoadDataCommand()
        {
            //var get = new GetViewData();
            //UserData = get.GetProtectSetPointList();
        }
        #endregion

        #region 保护定值选择，下载
        /// <summary>
        /// 启动传输控制功能
        /// </summary>
        public RelayCommand<string> SetProtectPoint { get; private set; }


        void ExecuteSetPreotectPoint(string str)
        {
            try
            {
                var slectData = GetDownloadProtectSetSelect();
                switch(str)
                {
                    case "Slected":
                        {
                            setPointServer.StartServer(true, CauseOfTransmissionList.Activation, 0,
                    new QualifyCommandSet(ActionDescrible.Select), slectData);
                            break;
                        }
                    case "Download":
                        {
                            setPointServer.SendActionCommand(true, CauseOfTransmissionList.Activation, 0,
                    new QualifyCommandSet(ActionDescrible.Execute), slectData);
                            break;
                        }
                }

                
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Exception>(ex, "ExceptionMessage");
            }
        }


        /// <summary>
        /// 保护定值选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private List<Tuple<UInt32, ShortFloating>> GetDownloadProtectSetSelect()
        {
            try
            {
                List<Tuple<UInt32, ShortFloating>> listFloat = new List<Tuple<uint, ShortFloating>>();
                if ((UserData != null) && (UserData.Count > 0))
                {
                    var qos = new QualifyCommandSet(ActionDescrible.Select);
               
                    foreach (var m in UserData)
                    {
                        if (m.InternalID <= UserData.Count)
                        {
                            var sf = new ShortFloating((float)m.ParameterValue);
                            var addr = m.InternalID + ProtectSetPoint.BasicAddress - 1;
                            listFloat.Add(new Tuple<uint, ShortFloating>((uint)addr, sf));
                        }
                        else
                        {
                            throw new Exception("序号不在顺序范围之内，无法使用序列化方法，请检查InternalID是否连续");
                        }
                    }
                    if (listFloat.Count > 0)
                    {
                        return listFloat;
                         
                    }
                    else
                    {
                        throw new Exception("定值列表为空");
                    }
                  
                }
                else
                {
                    throw new Exception("定值列表为空");
                }

            }
            catch (Exception ex)
            {
                Messenger.Default.Send<Exception>(ex, "ExceptionMessage");
                return null;
            }
        }
        #endregion
    }
}