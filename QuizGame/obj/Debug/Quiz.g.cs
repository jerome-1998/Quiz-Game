﻿#pragma checksum "..\..\Quiz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E6080CA5A6A293F0C63EE99E00B0997D8EDC52FDFA3DB7A53E243543C101235"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using QuizGame;
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


namespace QuizGame {
    
    
    /// <summary>
    /// Quiz
    /// </summary>
    public partial class Quiz : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGamePoints;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spJoker;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnJokerFiftyFifty;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnJokerTelephone;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnJokerCrowd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuestion;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spResults;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Quiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitGame;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizGame;component/quiz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Quiz.xaml"
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
            
            #line 9 "..\..\Quiz.xaml"
            ((QuizGame.Quiz)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblGamePoints = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.spJoker = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.btnJokerFiftyFifty = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Quiz.xaml"
            this.btnJokerFiftyFifty.Click += new System.Windows.RoutedEventHandler(this.BtnJoker_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnJokerTelephone = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Quiz.xaml"
            this.btnJokerTelephone.Click += new System.Windows.RoutedEventHandler(this.BtnJoker_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnJokerCrowd = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Quiz.xaml"
            this.btnJokerCrowd.Click += new System.Windows.RoutedEventHandler(this.BtnJoker_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblQuestion = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.spResults = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.btnExitGame = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Quiz.xaml"
            this.btnExitGame.Click += new System.Windows.RoutedEventHandler(this.BtnExitGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

