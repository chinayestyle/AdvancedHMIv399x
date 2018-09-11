using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen2Training
{
    public partial class OpenWindow : Form
    {
        public string filename { get; set; }

        public OpenWindow()
        {
            InitializeComponent();
        }
        public void LoadOpenWindow(object sender, System.EventArgs e)
        {
            axAcroPDF1.src = filename;
        }
    }
}
