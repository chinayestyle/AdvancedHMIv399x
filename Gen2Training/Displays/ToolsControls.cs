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
    public partial class ToolsControls : ToolsForm
    {
        public ToolsControls()
        {
            InitializeComponent();
        }

        public void Load_toolscontrols(object sender, System.EventArgs e)
        {
            ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
        }
    }
}
