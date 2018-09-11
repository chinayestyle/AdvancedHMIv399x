using Gen2Training.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen2Training.Displays
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
          
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void Load_Splashform(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            PictureBox spashPictureBox = new PictureBox();
            spashPictureBox.Image = Resources.Intralox_brochurecvr;
            spashPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            spashPictureBox.Dock = DockStyle.Fill;
            this.Controls.Add(spashPictureBox);
        }

        private delegate void CloseDelegate();

        private static SplashForm splashForm;

        static public void ShowSplashScreen()
        {
            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(SplashForm.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            splashForm = new SplashForm();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(SplashForm.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }

    }
}
