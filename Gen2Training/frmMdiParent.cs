using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MfgControl.AdvancedHMI;
using MfgControl.AdvancedHMI.Drivers;

namespace Gen2Training
{
    public partial class frmMdiParent : Form
    {
        public frmMdiParent()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(23, 32, 43);
            ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
            menuStrip1.MdiWindowListItem = menuStrip1.
            
        }
    }
}
