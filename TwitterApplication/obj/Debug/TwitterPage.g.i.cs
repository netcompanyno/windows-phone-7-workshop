﻿#pragma checksum "C:\Users\Envy\Documents\Visual Studio 2010\Projects\TwitterApplication\TwitterApplication\TwitterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7FBAB8D4C66629253386A497181D149"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TwitterApplication {
    
    
    public partial class TwitterPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid LayoutItem1;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox TweetsListBox;
        
        internal System.Windows.Controls.Grid LayoutItem2;
        
        internal System.Windows.Controls.ListBox FlicksListBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TwitterApplication;component/TwitterPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.LayoutItem1 = ((System.Windows.Controls.Grid)(this.FindName("LayoutItem1")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TweetsListBox = ((System.Windows.Controls.ListBox)(this.FindName("TweetsListBox")));
            this.LayoutItem2 = ((System.Windows.Controls.Grid)(this.FindName("LayoutItem2")));
            this.FlicksListBox = ((System.Windows.Controls.ListBox)(this.FindName("FlicksListBox")));
        }
    }
}
