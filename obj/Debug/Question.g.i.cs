﻿#pragma checksum "..\..\Question.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F98FA9543983FA235BFCEC10FD873CF848C4B30E"
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
using Test1;


namespace Test1 {
    
    
    /// <summary>
    /// Question
    /// </summary>
    public partial class Question : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Question.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Question.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Answer_1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Question.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Answer_2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Question.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Answer_3;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Question.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Answer_4;
        
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
            System.Uri resourceLocater = new System.Uri("/Test1;component/question.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Question.xaml"
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
            this.textblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Answer_1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\Question.xaml"
            this.Answer_1.Checked += new System.Windows.RoutedEventHandler(this.Answer_1_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Answer_2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\Question.xaml"
            this.Answer_2.Checked += new System.Windows.RoutedEventHandler(this.Answer_2_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Answer_3 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\Question.xaml"
            this.Answer_3.Checked += new System.Windows.RoutedEventHandler(this.Answer_3_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Answer_4 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 24 "..\..\Question.xaml"
            this.Answer_4.Checked += new System.Windows.RoutedEventHandler(this.Answer_4_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

