﻿#pragma checksum "..\..\..\Controls\RawSerialCommunication.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "069B2159F99B04B471A02875FCC76C78"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
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


namespace Sicily.Robotix.MicroController.CommunicationApplication.Controls {
    
    
    /// <summary>
    /// RawSerialCommunication
    /// </summary>
    public partial class RawSerialCommunication : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Shapes.Rectangle rctBackground;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.TextBlock txtRobotName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.Button btnSendInstructions;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.ComboBox lstEncoding;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.CheckBox chkAppendNewline;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.TextBox txtInstructions;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.Image imgPortClosed;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.Image imgPortOpen;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.TextBlock txtPortStatus;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.Button btnOpenClosePort;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Controls\RawSerialCommunication.xaml"
        internal System.Windows.Controls.TextBox txtResponse;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/Sicily.Robotix.RobotiTalk;component/controls/rawserialcommunication.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\RawSerialCommunication.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rctBackground = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 2:
            this.txtRobotName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnSendInstructions = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Controls\RawSerialCommunication.xaml"
            this.btnSendInstructions.Click += new System.Windows.RoutedEventHandler(this.btnSendInstructions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstEncoding = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.chkAppendNewline = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.txtInstructions = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.imgPortClosed = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.imgPortOpen = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.txtPortStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Controls\RawSerialCommunication.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnOpenClosePort = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Controls\RawSerialCommunication.xaml"
            this.btnOpenClosePort.Click += new System.Windows.RoutedEventHandler(this.btnOpenClosePort_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtResponse = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
