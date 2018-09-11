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

namespace Gen2Training
{
    public partial class Gen2TrainingSession : Form
    {
        public Gen2TrainingSession()
        {
            InitializeComponent();
        }

        public void Load_Gen2TrainingSession(object sender, EventArgs e)
        {
            this.ethernetIPforCLXCom1.IPAddress = Properties.Settings.Default.EthernetIpAddress;
        }

    
    }
}
