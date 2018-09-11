using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(23, 32, 43);
            ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
            Form activechild = this.ActiveMdiChild;
            if (activechild != null)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
        # region "Menu and Tool STrips"

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = null;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            if (filename != null)
            {
                string text = File.ReadAllText(filename);
                MessageBox.Show(text);
            }
        }

        private void manualsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Schematics";
            openFileDialog1.InitialDirectory = "\\prod\\root\\V_Drive\\team\\Intralox Spiral Team Videos and Large Files\\CONTROLS\\2 - Gen II Controls\\1- Documentation\\pdf";
            openFileDialog1.Filter = "PDF Files|*.pdf";

            string filename = null;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            if (filename != null)
            {
                OpenWindow openWindow = new OpenWindow();
                openWindow.filename = filename;
                openWindow.Show();

            }
        }

        private void schematicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Schematics";
            openFileDialog1.Filter = "PDF Files|*.pdf";
            openFileDialog1.InitialDirectory = "C:\\Users\\erick\\OneDrive\\Documents\\Spiral-Surface";
            string filename = null;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            if (filename != null)
            {
                OpenWindow openWindow = new OpenWindow();
                openWindow.filename = filename;
                openWindow.Show();

            }

        }
        private void trainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_Overview newMDIChild = new A_Overview();
            //set the parent form of the child window.
            newMDIChild.MdiParent = this;
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
            button1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        #endregion

        #region "Next Button"

        private void button1_Click(object sender, EventArgs e)
        {
            Form activeform = ActiveMdiChild;
            if (activeform.GetType() == typeof(A_Overview))
            {
                C_MotorNameplateData frmoverview = new C_MotorNameplateData();
                frmoverview.MdiParent = this;
                frmoverview.Dock = DockStyle.Fill;
                frmoverview.Show();
                this.Refresh();
            }
            else if (activeform.GetType() == typeof(C_MotorNameplateData))
            {
                D_InitialTorqueSetpoint frmnameplate = new D_InitialTorqueSetpoint();
                frmnameplate.MdiParent = this;
                frmnameplate.Dock = DockStyle.Fill;
                frmnameplate.Show();
                this.Refresh();
            }

            else if (activeform.GetType() == typeof(C_MotorNameplateData))
            {
                D_InitialTorqueSetpoint frminitialtorquesetpoint = new D_InitialTorqueSetpoint();
                frminitialtorquesetpoint.MdiParent = this;
                frminitialtorquesetpoint.Dock = DockStyle.Fill;
                frminitialtorquesetpoint.Show();
                this.Refresh();
            }


            else if (activeform.GetType() == typeof(D_InitialTorqueSetpoint))
            {
                E_InitialSpeed_Scaling_Factor frminitialscalingfactor = new E_InitialSpeed_Scaling_Factor();
                frminitialscalingfactor.MdiParent = this;
                frminitialscalingfactor.Dock = DockStyle.Fill;
                frminitialscalingfactor.Show();
                this.Refresh();
            }

            else
            {
                const string message = "Thank you for completing the Training Session. Click Ok to exit./n Would you like to e-mail yourself a recording of this session?";

                const string caption = "Session Completed";

                var result = MessageBox.Show(message, caption,
                                            MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Information);

            }

        }
        #endregion

    
    }
}
