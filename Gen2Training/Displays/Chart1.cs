using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MfgControl.AdvancedHMI.Controls;
using MfgControl.AdvancedHMI.Drivers;
using AdvancedHMIControls;

namespace Gen2Training.Displays
{
    public partial class Chart1 : Form
    {
        static EthernetIPforCLX ethernet1 = new EthernetIPforCLX()
        {
            IPAddress = "172.16.30.55"
        };

        static DataSubscriber subscriber = new DataSubscriber()
        {
            PLCAddressValue = new PLCAddressItem("Load_Cell_Percent"),
            ComComponent = ethernet1
        };

        public Chart1()
        {
            InitializeComponent();
         
        }
        
        public void thisservice()
        {
           
        }


        private void subscriber_OnDataChanged(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {
            //if (e.ErrorId ==0 && e.Values != null && e.Values.Count() > 0)
            //{
            //    try
            //    {
            //        if (e.PlcAddress == subscriber.PLCAddressValue.PLCAddress)
            //        {

            //        };
            //    }
            }
        }
    }

