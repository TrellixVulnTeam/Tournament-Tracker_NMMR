﻿#pragma checksum "..\..\..\CreateTournament.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F02BC5B74943A0D07C34C9E14F540F0B59B9E27"
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
using TournamentTrackerUI;


namespace TournamentTrackerUI {
    
    
    /// <summary>
    /// CreateTournament
    /// </summary>
    public partial class CreateTournament : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox selectTeam_listbx;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tournamentNameValue;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox entryFeeValue;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTeamBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreatePrizeBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox tournamentTeams_ListBx;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTournamentBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveSelectedTeam_Btn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemovePrizes_btn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox prizes_ListBx;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\CreateTournament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CreateTeamLink;
        
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
            System.Uri resourceLocater = new System.Uri("/TournamentTrackerUI;component/createtournament.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateTournament.xaml"
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
            this.selectTeam_listbx = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.tournamentNameValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.entryFeeValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AddTeamBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\CreateTournament.xaml"
            this.AddTeamBtn.Click += new System.Windows.RoutedEventHandler(this.AddTeamBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreatePrizeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\CreateTournament.xaml"
            this.CreatePrizeBtn.Click += new System.Windows.RoutedEventHandler(this.CreatePrizeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tournamentTeams_ListBx = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.CreateTournamentBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\CreateTournament.xaml"
            this.CreateTournamentBtn.Click += new System.Windows.RoutedEventHandler(this.CreateTournamentBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoveSelectedTeam_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\CreateTournament.xaml"
            this.RemoveSelectedTeam_Btn.Click += new System.Windows.RoutedEventHandler(this.RemoveSelectedTeam_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RemovePrizes_btn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\CreateTournament.xaml"
            this.RemovePrizes_btn.Click += new System.Windows.RoutedEventHandler(this.RemovePrizes_btn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.prizes_ListBx = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.CreateTeamLink = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            
            #line 49 "..\..\..\CreateTournament.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateTeamLink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

