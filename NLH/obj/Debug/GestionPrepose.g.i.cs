﻿#pragma checksum "..\..\GestionPrepose.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6D1D4E75F669B7D7C1AF6FBDD6B56D251EAB5E4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using NLH;
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


namespace NLH {
    
    
    /// <summary>
    /// GestionPrepose
    /// </summary>
    public partial class GestionPrepose : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dateprep;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxNom;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPrenom;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxspes;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMod;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSup;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitter;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\GestionPrepose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comb1;
        
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
            System.Uri resourceLocater = new System.Uri("/NLH;component/gestionprepose.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionPrepose.xaml"
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
            
            #line 8 "..\..\GestionPrepose.xaml"
            ((NLH.GestionPrepose)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dateprep = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.tbxNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbxPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbxspes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnMod = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\GestionPrepose.xaml"
            this.btnMod.Click += new System.Windows.RoutedEventHandler(this.btnMod_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSup = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\GestionPrepose.xaml"
            this.btnSup.Click += new System.Windows.RoutedEventHandler(this.btnSup_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\GestionPrepose.xaml"
            this.btnQuitter.Click += new System.Windows.RoutedEventHandler(this.btnQuitter_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comb1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\GestionPrepose.xaml"
            this.comb1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comb1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

