﻿#pragma checksum "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F63F2A70C23FA34198577734A83ABA70FC2E0B4F0E2B97FA731EABFDA23A1A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login_Interface.NavigationPannelPages;
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


namespace Login_Interface.NavigationPannelPages {
    
    
    /// <summary>
    /// BookLoan_Menu
    /// </summary>
    public partial class BookLoan_Menu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_button;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddLoan_button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteLoan_button;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditLoan_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Login Interface;component/navigationpannelpages/bookloan_menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
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
            
            #line 19 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
            this.Back_button.Click += new System.Windows.RoutedEventHandler(this.Back_button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddLoan_button = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\NavigationPannelPages\BookLoan_Menu.xaml"
            this.AddLoan_button.Click += new System.Windows.RoutedEventHandler(this.AddLoan_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteLoan_button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.EditLoan_button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

