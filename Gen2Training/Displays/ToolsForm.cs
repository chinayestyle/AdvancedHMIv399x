using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen2Training.Displays
{
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
        }

        public void Load_Toolsform(object sender, EventArgs e)
        {
            ethernetIPforCLXCom1.IPAddress = Properties.Settings.Default.EthernetIpAddress; 
        }
    }
}
