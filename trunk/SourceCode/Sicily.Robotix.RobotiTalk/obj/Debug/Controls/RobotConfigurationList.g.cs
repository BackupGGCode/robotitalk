﻿#pragma checksum "..\..\..\Controls\RobotConfigurationList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "15B058C8D42CA902485AE60D44AE1B05"
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
    /// RobotConfigurationList
    /// </summary>
    public partial class RobotConfigurationList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Controls\RobotConfigurationList.xaml"
        internal System.Windows.Controls.ListView lstRobotConfigurations;
        
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
            System.Uri resourceLocater = new System.Uri("/Sicily.Robotix.RobotiTalk;component/controls/robotconfigurationlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\RobotConfigurationList.xaml"
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
            this.lstRobotConfigurations = ((System.Windows.Controls.ListView)(target));
            
            #line 5 "..\..\..\Controls\RobotConfigurationList.xaml"
            this.lstRobotConfigurations.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstRobotConfigurations_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
