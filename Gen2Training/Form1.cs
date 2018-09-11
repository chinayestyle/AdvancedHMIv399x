using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMIDrivers; 

namespace Gen2Training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
        }
    }
}
