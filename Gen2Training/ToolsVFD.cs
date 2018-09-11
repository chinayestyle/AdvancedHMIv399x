using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gen2Training.Displays;

namespace Gen2Training
{
    public partial class ToolsVFD : ToolsForm
    {
        public ToolsVFD()
        {
            InitializeComponent();
        }

        public void LoadToolsVFD(object sender, System.EventArgs e)
        {
            ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
        }

        private void groupPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
