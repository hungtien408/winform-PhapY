﻿#pragma checksum "..\..\..\..\uc\TimeTextbox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "887E78A731A7D6EBB4462B9F50C48481"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PhapY.uc;
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


namespace PhapY.uc {
    
    
    /// <summary>
    /// TimeTextbox
    /// </summary>
    public partial class TimeTextbox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\uc\TimeTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHours;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\uc\TimeTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHours;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\uc\TimeTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMinutes;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\uc\TimeTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMinutes;
        
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
            System.Uri resourceLocater = new System.Uri("/PhapY;component/uc/timetextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\uc\TimeTextbox.xaml"
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
            
            #line 7 "..\..\..\..\uc\TimeTextbox.xaml"
            ((PhapY.uc.TimeTextbox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblHours = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtHours = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtHours.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtHours_KeyDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtHours.GotFocus += new System.Windows.RoutedEventHandler(this.txtHours_GotFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtHours.LostFocus += new System.Windows.RoutedEventHandler(this.txtHours_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblMinutes = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtMinutes = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtMinutes.GotFocus += new System.Windows.RoutedEventHandler(this.txtMinutes_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtMinutes.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtMinutes_KeyDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\uc\TimeTextbox.xaml"
            this.txtMinutes.LostFocus += new System.Windows.RoutedEventHandler(this.txtMinutes_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

