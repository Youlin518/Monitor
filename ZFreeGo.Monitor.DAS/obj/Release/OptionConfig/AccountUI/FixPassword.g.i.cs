﻿#pragma checksum "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29607839E12FCB89FB95C38EF4572828"
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
    /// FixPassword
    /// </summary>
    public partial class FixPassword : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox currentUserName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxOld;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxNew;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxNewRepeat;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFixPassword;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ZFreeGo.Monitor.AutoStudio;component/optionconfig/accountui/fixpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
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
            this.passBoxOld = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.passBoxNew = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.passBoxNewRepeat = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnFixPassword = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
            this.btnFixPassword.Click += new System.Windows.RoutedEventHandler(this.btnFixPassword_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\OptionConfig\AccountUI\FixPassword.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

