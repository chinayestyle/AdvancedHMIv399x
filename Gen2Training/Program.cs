using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gen2Training.Displays;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Gen2Training
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SplashForm.ShowSplashScreen();
            frmMdiParent frmMdiParent = new frmMdiParent();
            SplashForm.CloseForm();
            Application.EnableVisualStyles();
            Application.Run(frmMdiParent);
        }
    }
}
