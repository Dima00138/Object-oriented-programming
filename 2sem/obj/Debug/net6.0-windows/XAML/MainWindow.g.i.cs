﻿#pragma checksum "..\..\..\..\XAML\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E60AA9CAFA9100BA1A06F43E273C18D8CDC0C9F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseWork;
using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using ModernWpf.DesignTime;
using ModernWpf.Markup;
using ModernWpf.Media.Animation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CourseWork {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelHead;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Shedule_Button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button View_Shedule_Button;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainPage;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Eng_loc_button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rus_loc_button;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ModernWpf.Controls.ToggleSwitch Theme;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CourseWork.ButtonC CustomControl1_B;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\XAML\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Ellip;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CourseWork;V1.0.0.0;component/xaml/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\XAML\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelHead = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Shedule_Button = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\XAML\MainWindow.xaml"
            this.Shedule_Button.Click += new System.Windows.RoutedEventHandler(this.Shedule_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.View_Shedule_Button = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\XAML\MainWindow.xaml"
            this.View_Shedule_Button.Click += new System.Windows.RoutedEventHandler(this.View_Shedule_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainPage = ((System.Windows.Controls.Frame)(target));
            return;
            case 5:
            this.Eng_loc_button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\XAML\MainWindow.xaml"
            this.Eng_loc_button.Click += new System.Windows.RoutedEventHandler(this.Eng_loc_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Rus_loc_button = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\XAML\MainWindow.xaml"
            this.Rus_loc_button.Click += new System.Windows.RoutedEventHandler(this.Rus_loc_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Theme = ((ModernWpf.Controls.ToggleSwitch)(target));
            
            #line 44 "..\..\..\..\XAML\MainWindow.xaml"
            this.Theme.Toggled += new System.Windows.RoutedEventHandler(this.ToggleSwitch_Toggled);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CustomControl1_B = ((CourseWork.ButtonC)(target));
            return;
            case 9:
            this.Ellip = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 46 "..\..\..\..\XAML\MainWindow.xaml"
            this.Ellip.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CustomControl1_B_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
