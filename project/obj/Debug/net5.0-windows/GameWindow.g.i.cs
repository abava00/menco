﻿#pragma checksum "..\..\..\GameWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206D42FF68ECD481FDAFE2134F604D4DC69E14C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

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
using project;


namespace project {
    
    
    /// <summary>
    /// GameWindow
    /// </summary>
    public partial class GameWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid OperationArea;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GameWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Target;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/project;component/gamewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GameWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 2 "..\..\..\GameWindow.xaml"
            ((project.GameWindow)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.OperationArea_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OperationArea = ((System.Windows.Controls.Grid)(target));
            
            #line 12 "..\..\..\GameWindow.xaml"
            this.OperationArea.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OperationArea_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\GameWindow.xaml"
            this.OperationArea.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OperationArea_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\GameWindow.xaml"
            this.OperationArea.MouseMove += new System.Windows.Input.MouseEventHandler(this.OperationArea_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Target = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
