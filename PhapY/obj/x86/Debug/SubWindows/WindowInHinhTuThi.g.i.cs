﻿#pragma checksum "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "82283FA32305F22FFC39F94640BA8481"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    /// WindowInHinhTuThi
    /// </summary>
    public partial class WindowInHinhTuThi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChonHinh;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXemHinhDuocChon;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTenDS;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNamSinh;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Container;
        
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
            System.Uri resourceLocater = new System.Uri("/PhapY;component/subwindows/windowinhinhtuthi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
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
            this.toolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 2:
            this.btnChonHinh = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
            this.btnChonHinh.Click += new System.Windows.RoutedEventHandler(this.btnChonHinh_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnXemHinhDuocChon = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\SubWindows\WindowInHinhTuThi.xaml"
            this.btnXemHinhDuocChon.Click += new System.Windows.RoutedEventHandler(this.btnXemHinhDuocChon_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblTenDS = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblNamSinh = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Container = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

