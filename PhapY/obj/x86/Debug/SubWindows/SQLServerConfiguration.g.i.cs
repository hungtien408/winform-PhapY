﻿#pragma checksum "..\..\..\..\SubWindows\SQLServerConfiguration.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A0729F69B8A907AB28AFCF493705B055"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ComponentArt.Win.UI.Input;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PhapY.SubWindows {
    
    
    /// <summary>
    /// SQLServerConfiguration
    /// </summary>
    public partial class SQLServerConfiguration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ComponentArt.Win.UI.Input.ComboBox cbxServerName;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshServerName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkWindowAccount;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkSQLAccount;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ComponentArt.Win.UI.Input.ComboBox cbxDatabaseName;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshDatabaseName;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTest;
        
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
            System.Uri resourceLocater = new System.Uri("/PhapY;component/subwindows/sqlserverconfiguration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
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
            this.cbxServerName = ((ComponentArt.Win.UI.Input.ComboBox)(target));
            
            #line 38 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.cbxServerName.SelectionFinalized += new ComponentArt.Win.UI.Input.ComboBox.ComboBoxEventHandler(this.cbxServerName_SelectionFinalized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRefreshServerName = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.btnRefreshServerName.Click += new System.Windows.RoutedEventHandler(this.btnRefreshServerName_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkWindowAccount = ((System.Windows.Controls.RadioButton)(target));
            
            #line 74 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.chkWindowAccount.Checked += new System.Windows.RoutedEventHandler(this.chkWindowAccount_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkSQLAccount = ((System.Windows.Controls.RadioButton)(target));
            
            #line 81 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.chkSQLAccount.Checked += new System.Windows.RoutedEventHandler(this.chkSQLAccount_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.cbxDatabaseName = ((ComponentArt.Win.UI.Input.ComboBox)(target));
            return;
            case 8:
            this.btnRefreshDatabaseName = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.btnRefreshDatabaseName.Click += new System.Windows.RoutedEventHandler(this.btnRefreshDatabaseName_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnTest = ((System.Windows.Controls.Button)(target));
            
            #line 196 "..\..\..\..\SubWindows\SQLServerConfiguration.xaml"
            this.btnTest.Click += new System.Windows.RoutedEventHandler(this.btnTest_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

