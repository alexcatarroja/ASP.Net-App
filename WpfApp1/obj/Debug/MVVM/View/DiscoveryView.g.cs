﻿#pragma checksum "..\..\..\..\MVVM\View\DiscoveryView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59D294656DA6B5296B52F0695FF7C46D48444169F52B49CF940273972D35C4E8"
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
using WpfApp1.MVVM.View;


namespace WpfApp1.MVVM.View {
    
    
    /// <summary>
    /// DiscoveryView
    /// </summary>
    public partial class DiscoveryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonthlySalary;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Savings;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SavingsText;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Wants;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WantsTxt;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Necessities;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NeedsTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mvvm/view/discoveryview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
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
            this.MonthlySalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Savings = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.SavingsText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Wants = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.WantsTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Necessities = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.NeedsTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 93 "..\..\..\..\MVVM\View\DiscoveryView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

