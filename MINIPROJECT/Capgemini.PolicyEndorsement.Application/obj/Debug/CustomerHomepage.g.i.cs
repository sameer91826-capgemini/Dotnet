﻿#pragma checksum "..\..\CustomerHomepage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BAAF67153F5626D8F2CA5B01EAFEFEE68CA5E614"
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
    /// CustomerHomepage
    /// </summary>
    public partial class CustomerHomepage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CustomerHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustNum;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\CustomerHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtSearchandUpdate;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CustomerHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtViewEndorse;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CustomerHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txtStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/Capgemini.PolicyEndorsement.Application;component/customerhomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerHomepage.xaml"
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
            this.txtCustNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtSearchandUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\CustomerHomepage.xaml"
            this.txtSearchandUpdate.Click += new System.Windows.RoutedEventHandler(this.TxtSearchandUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtViewEndorse = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CustomerHomepage.xaml"
            this.txtViewEndorse.Click += new System.Windows.RoutedEventHandler(this.TxtViewEndorse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtStatus = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\CustomerHomepage.xaml"
            this.txtStatus.Click += new System.Windows.RoutedEventHandler(this.TxtStatus_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

