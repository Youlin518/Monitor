﻿#pragma checksum "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B002E729991B8FC26E3E11333CF3FFB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
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


namespace ZFreeGo.Monitor.AutoStudio.OptionConfig.AccountUI {
    
    
    /// <summary>
    /// FixAuthority
    /// </summary>
    public partial class FixAuthority : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox currentUserName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioLevelI;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioLevelII;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioLevelIII;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioLevelIV;
        
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
            System.Uri resourceLocater = new System.Uri("/ZFreeGo.Monitor.AutoStudio;component/optionconfig/accountui/fixauthority.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
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
            this.currentUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.radioLevelI = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
            this.radioLevelI.Checked += new System.Windows.RoutedEventHandler(this.radioLevel_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.radioLevelII = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
            this.radioLevelII.Checked += new System.Windows.RoutedEventHandler(this.radioLevel_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.radioLevelIII = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
            this.radioLevelIII.Checked += new System.Windows.RoutedEventHandler(this.radioLevel_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.radioLevelIV = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
            this.radioLevelIV.Checked += new System.Windows.RoutedEventHandler(this.radioLevel_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\..\..\OptionConfig\AccountUI\FixAuthority.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnApplyChanged_Cliked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

