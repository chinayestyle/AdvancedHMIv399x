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
using MfgControl.AdvancedHMI.Drivers;
using AdvancedHMIControls;

namespace Gen2Training
{
    public partial class C_MotorNameplateData : Gen2TrainingSession
    {
        public C_MotorNameplateData()
        {
            InitializeComponent();
        }

        private void C_Load(object sender, System.EventArgs e)
        {
            Globals globals = new Globals();
            Dictionary<int, Globals.MotorParameters> nameplatedict = globals.ParamDict();
            int paramcount = 7;
            BasicLabel[] labels = new BasicLabel[paramcount];
            TextBox[] textBoxes = new TextBox[paramcount];
            var LabelLocation = new Point(200, 200);
            var TextBoxLocation = new Point(500, 200);
            //Adding controls programmatically. For every motor nameplate parameter, add a label and a textbox
            foreach (KeyValuePair<int, Globals.MotorParameters> entry in nameplatedict )
            {
                labels[entry.Key] = new BasicLabel();
                labels[entry.Key].Text = entry.Value.ParameterName;
                labels[entry.Key].Location = LabelLocation;
                labels[entry.Key].AutoSize = true;
                labels[entry.Key].ValueSuffix = entry.Value.Unit;
                LabelLocation.Y += 100;
                textBoxes[entry.Key] = new TextBox();
                textBoxes[entry.Key].Text = entry.Value.Unit;
                textBoxes[entry.Key].Location = TextBoxLocation;
                textBoxes[entry.Key].AutoSize = true;
                TextBoxLocation.X += 100;
            }
            for (int i = 1; i < paramcount; i++)
            {
                this.Controls.Add(labels[i]);
                this.Controls.Add(textBoxes[i]);
            }
        }


       
    }
}
