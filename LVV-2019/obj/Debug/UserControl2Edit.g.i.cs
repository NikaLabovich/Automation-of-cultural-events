﻿#pragma checksum "..\..\UserControl2Edit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91E6F87BDE40B0B23EEB5DC56DE0704E7C9DEF85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace LVV_2019 {
    
    
    /// <summary>
    /// UserControl2Edit
    /// </summary>
    public partial class UserControl2Edit : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Border;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Path;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlaceBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\UserControl2Edit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateBox;
        
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
            System.Uri resourceLocater = new System.Uri("/LVV-2019;component/usercontrol2edit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControl2Edit.xaml"
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
            this.Border = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Path = ((System.Windows.Shapes.Path)(target));
            
            #line 37 "..\..\UserControl2Edit.xaml"
            this.Path.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Path_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PlaceBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TypeBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.DateBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            
            #line 69 "..\..\UserControl2Edit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

