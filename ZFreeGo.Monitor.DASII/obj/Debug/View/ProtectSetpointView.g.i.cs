﻿#pragma checksum "..\..\..\View\ProtectSetpointView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6036EC11304026B7B6E3CB0281BE7D54"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ZFreeGo.Monitor.DASII.View {
    
    
    /// <summary>
    /// ProtectSetpointView
    /// </summary>
    public partial class ProtectSetpointView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCallSetpoint;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadProtectSetSelect;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadProtectSet;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProtectSetPointExport;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProtectSetPointLoad;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxProtectSetPoint;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\ProtectSetpointView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridProtectSetPoint;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZFreeGo.Monitor.DASII;component/view/protectsetpointview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProtectSetpointView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnCallSetpoint = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.DownloadProtectSetSelect = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.DownloadProtectSet = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.ProtectSetPointExport = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ProtectSetPointLoad = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.CheckBoxProtectSetPoint = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.gridProtectSetPoint = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

