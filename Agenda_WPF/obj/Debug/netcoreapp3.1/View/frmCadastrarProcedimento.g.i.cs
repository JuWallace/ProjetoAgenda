﻿#pragma checksum "..\..\..\..\View\frmCadastrarProcedimento.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D22A2F5B2978EB69D7B50A8BE6DE28A89000DF1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewAgenda_WPF.Views.procedimento;
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


namespace NewAgenda_WPF.Views.procedimento {
    
    
    /// <summary>
    /// frmCadastrarProcedimento
    /// </summary>
    public partial class frmCadastrarProcedimento : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProcedimento;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtValor;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGravar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSair;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Agenda_WPF;V1.0.0.0;component/view/frmcadastrarprocedimento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtProcedimento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtValor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnGravar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
            this.btnGravar.Click += new System.Windows.RoutedEventHandler(this.btnGravar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSair = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\frmCadastrarProcedimento.xaml"
            this.btnSair.Click += new System.Windows.RoutedEventHandler(this.btnSair_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

