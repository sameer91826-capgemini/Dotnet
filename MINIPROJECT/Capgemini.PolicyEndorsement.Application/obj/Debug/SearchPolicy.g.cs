﻿#pragma checksum "..\..\SearchPolicy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4E2EE3510A5A0199C3742FD0CA9C7A42867FBC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capgemini.PolicyEndorsement.Application;
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


namespace Capgemini.PolicyEndorsement.Application {
    
    
    /// <summary>
    /// SearchPolicy
    /// </summary>
    public partial class SearchPolicy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtpolicyID;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPolicy;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustNum;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPolicyCNum;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDob;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SearchPolicy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPolicyName;
        
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
            System.Uri resourceLocater = new System.Uri("/Capgemini.PolicyEndorsement.Application;component/searchpolicy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchPolicy.xaml"
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
            this.txtpolicyID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\SearchPolicy.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgPolicy = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\SearchPolicy.xaml"
            this.dgPolicy.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgPolicy_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCustNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSearch1 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\SearchPolicy.xaml"
            this.btnSearch1.Click += new System.Windows.RoutedEventHandler(this.BtnSearch1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgPolicyCNum = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\SearchPolicy.xaml"
            this.dgPolicyCNum.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgPolicyCNum_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtDob = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSearch2 = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\SearchPolicy.xaml"
            this.btnSearch2.Click += new System.Windows.RoutedEventHandler(this.BtnSearch2_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgPolicyName = ((System.Windows.Controls.DataGrid)(target));
            
            #line 33 "..\..\SearchPolicy.xaml"
            this.dgPolicyName.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgPolicyName_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

