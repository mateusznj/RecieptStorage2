﻿#pragma checksum "C:\Users\mateusz.nostitz-jack\Desktop\SkyDrive\WSB\PROJEKT\ReceiptStorage2\View\AddShop.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA40A6669D2AAB0BF8EE5C5723DF31EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
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


namespace ReceiptStorage.View {
    
    
    public partial class AddShop : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBox tbName;
        
        internal System.Windows.Controls.TextBox tbCity;
        
        internal System.Windows.Controls.TextBox tbAdress;
        
        internal Microsoft.Phone.Controls.ListPicker lpkCountry;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ReceiptStorage;component/View/AddShop.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.tbName = ((System.Windows.Controls.TextBox)(this.FindName("tbName")));
            this.tbCity = ((System.Windows.Controls.TextBox)(this.FindName("tbCity")));
            this.tbAdress = ((System.Windows.Controls.TextBox)(this.FindName("tbAdress")));
            this.lpkCountry = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkCountry")));
        }
    }
}

