﻿#pragma checksum "..\..\AddBookLoan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0E396BCDFD19719E7047BD0AF194CA16F5B41C2A5345724D860220432CE99E3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login_Interface;
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


namespace Login_Interface {
    
    
    /// <summary>
    /// AddBookLoan
    /// </summary>
    public partial class AddBookLoan : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Section;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CopyID;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ISBN;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddLoan;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ActiveLoanSection;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ActiveLoanBorder;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\AddBookLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ActiveLoans;
        
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
            System.Uri resourceLocater = new System.Uri("/Login Interface;component/addbookloan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddBookLoan.xaml"
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
            this.Back_button = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\AddBookLoan.xaml"
            this.Back_button.Click += new System.Windows.RoutedEventHandler(this.Back_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Section = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CopyID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ISBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddLoan = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.ActiveLoanSection = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.ActiveLoanBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.ActiveLoans = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
