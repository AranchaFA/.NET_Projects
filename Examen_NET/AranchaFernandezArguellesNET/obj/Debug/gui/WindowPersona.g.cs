﻿#pragma checksum "..\..\..\gui\WindowPersona.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A75835B37DF4F00E9FD40A80B03727649C385609"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace AranchaFernandezArguellesNET.gui {
    
    
    /// <summary>
    /// WindowPersona
    /// </summary>
    public partial class WindowPersona : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_nombre;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_apellidos;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Nombre;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_apellidos;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_insertar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\gui\WindowPersona.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/AranchaFernandezArguellesNET;component/gui/windowpersona.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\gui\WindowPersona.xaml"
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
            this.lbl_nombre = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lbl_apellidos = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textbox_Nombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\..\gui\WindowPersona.xaml"
            this.textbox_Nombre.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 4:
            this.textbox_apellidos = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\..\gui\WindowPersona.xaml"
            this.textbox_apellidos.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_insertar = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\gui\WindowPersona.xaml"
            this.bt_insertar.Click += new System.Windows.RoutedEventHandler(this.clickInsertar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bt_cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\gui\WindowPersona.xaml"
            this.bt_cancelar.Click += new System.Windows.RoutedEventHandler(this.clickCancelar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
