﻿#pragma checksum "C:\Users\mateusz.nostitz-jack\Desktop\SkyDrive\WSB\PROJEKT\ReceiptStorage2\View\Add.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA634212A30AB3A53861B008B786D0E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
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
    
    
    public partial class Add : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker lpkShop;
        
        internal System.Windows.Controls.Button btAddShop;
        
        internal Microsoft.Phone.Controls.ListPicker lpkShopsCategory;
        
        internal Microsoft.Phone.Controls.DatePicker dpDataParagonu;
        
        internal Microsoft.Phone.Controls.ListPicker lpkOperationType;
        
        internal System.Windows.Controls.TextBox tbKwota;
        
        internal Microsoft.Phone.Controls.ListPicker lpkOcrResult;
        
        internal System.Windows.Controls.Image ReceiptImage;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ReceiptStorage;component/View/Add.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.lpkShop = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkShop")));
            this.btAddShop = ((System.Windows.Controls.Button)(this.FindName("btAddShop")));
            this.lpkShopsCategory = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkShopsCategory")));
            this.dpDataParagonu = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("dpDataParagonu")));
            this.lpkOperationType = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkOperationType")));
            this.tbKwota = ((System.Windows.Controls.TextBox)(this.FindName("tbKwota")));
            this.lpkOcrResult = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkOcrResult")));
            this.ReceiptImage = ((System.Windows.Controls.Image)(this.FindName("ReceiptImage")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
        }
    }
}

