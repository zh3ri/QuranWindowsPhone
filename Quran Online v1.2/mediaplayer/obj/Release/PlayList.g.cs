﻿#pragma checksum "C:\Users\ASUS S550C\Desktop\Quran online v 2.3\Quran Online v1.2\mediaplayer\PlayList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "23FE15112DD5694E209030CF107B5D70"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace mediaplayer {
    
    
    public partial class PlayList : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.LongListSelector ListAuther65;
        
        internal System.Windows.Controls.TextBlock txtpos;
        
        internal System.Windows.Controls.TextBlock txtlength;
        
        internal System.Windows.Controls.Slider bupos;
        
        internal System.Windows.Controls.TextBlock PlayAya;
        
        internal System.Windows.Controls.Image Backword;
        
        internal System.Windows.Controls.Image Forword;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/mediaplayer;component/PlayList.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ListAuther65 = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ListAuther65")));
            this.txtpos = ((System.Windows.Controls.TextBlock)(this.FindName("txtpos")));
            this.txtlength = ((System.Windows.Controls.TextBlock)(this.FindName("txtlength")));
            this.bupos = ((System.Windows.Controls.Slider)(this.FindName("bupos")));
            this.PlayAya = ((System.Windows.Controls.TextBlock)(this.FindName("PlayAya")));
            this.Backword = ((System.Windows.Controls.Image)(this.FindName("Backword")));
            this.Forword = ((System.Windows.Controls.Image)(this.FindName("Forword")));
        }
    }
}

