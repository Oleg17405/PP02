﻿#pragma checksum "..\..\AddOrderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "95BA055FDFDACC1FE4118EC882FA71374412174B96C7E8B85EC4D1EC21A0B9C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OhtaPark;
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


namespace OhtaPark {
    
    
    /// <summary>
    /// AddOrderWindow
    /// </summary>
    public partial class AddOrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimerLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Codetb;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Orderdp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ordertime;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statuscb;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker returndp;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timetb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox servicecb;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clientscb;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savebt;
        
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
            System.Uri resourceLocater = new System.Uri("/OhtaPark;component/addorderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddOrderWindow.xaml"
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
            this.TimerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Codetb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Orderdp = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.ordertime = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\AddOrderWindow.xaml"
            this.ordertime.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ordertime_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 21 "..\..\AddOrderWindow.xaml"
            this.ordertime.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.timetb_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\AddOrderWindow.xaml"
            this.ordertime.GotFocus += new System.Windows.RoutedEventHandler(this.timetb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.statuscb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.returndp = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.timetb = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AddOrderWindow.xaml"
            this.timetb.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.timetb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.servicecb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.clientscb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.AddBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AddOrderWindow.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.savebt = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddOrderWindow.xaml"
            this.savebt.Click += new System.Windows.RoutedEventHandler(this.savebt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
