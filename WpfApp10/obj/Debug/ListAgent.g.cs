#pragma checksum "..\..\ListAgent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0E84CD8A0B6ECB66986F943D8775C0CF6993507BF0B9B389F1BAFA439C9D10A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp10;


namespace WpfApp10 {
    
    
    /// <summary>
    /// ListAgent
    /// </summary>
    public partial class ListAgent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp10.ListAgent LoadCo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cmbSort;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeCmb;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid agentGrid;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel paging;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock full;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pagin;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forward;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateButton;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\ListAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp10;component/listagent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListAgent.xaml"
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
            this.LoadCo = ((WpfApp10.ListAgent)(target));
            return;
            case 2:
            
            #line 50 "..\..\ListAgent.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 51 "..\..\ListAgent.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbSort = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 5:
            this.TypeCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\ListAgent.xaml"
            this.TypeCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.agentGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 83 "..\..\ListAgent.xaml"
            this.agentGrid.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.agentGrid_MouseDown);
            
            #line default
            #line hidden
            
            #line 83 "..\..\ListAgent.xaml"
            this.agentGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.agentGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 7:
            this.paging = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.full = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\ListAgent.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.pagin = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.forward = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\ListAgent.xaml"
            this.forward.Click += new System.Windows.RoutedEventHandler(this.forward_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.updateButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\ListAgent.xaml"
            this.updateButton.Click += new System.Windows.RoutedEventHandler(this.updateButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\ListAgent.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

