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
            this.AutoScroll = true;
            groupPanel2.AutoSize = true;
            groupPanel1.AutoSize = true;
        }

        private void C_Load(object sender, System.EventArgs e)
        {
            Globals globals = new Globals();
            globals.plcipaddressglobal = "172.16.30.55";
            ethernetIPforCLXCom1.IPAddress = globals.plcipaddressglobal;
            Dictionary<int, Globals.MotorParameters> nameplatedict = globals.ParamDict();
            int paramcount = 7;
            BasicLabel[] labels = new BasicLabel[paramcount];
            Label[] textBoxes = new Label[paramcount];
            Label[] paramnumber = new Label[paramcount];
            var LabelLocation = new Point(300, 200);
            var TextBoxLocation = new Point(50, 200);
            var paramnumberlocation = new Point(9, 200);
            
            //Adding controls programmatically. For every motor nameplate parameter, add a label and a textbox
            foreach (KeyValuePair<int, Globals.MotorParameters> entry in nameplatedict )
            {
                labels[entry.Key] = new BasicLabel();
                labels[entry.Key].ComComponent = ethernetIPforCLXCom1;
                labels[entry.Key].Text = entry.Value.ParameterName;
                labels[entry.Key].PLCAddressValue = entry.Value.plcaddress;
                labels[entry.Key].PLCAddressKeypad = entry.Value.plcaddress;
                labels[entry.Key].Font = new Font("Arial", this.richTextBox1.Font.Size);
                labels[entry.Key].Location = LabelLocation;
                labels[entry.Key].AutoSize = true;
                labels[entry.Key].Value = "";
                labels[entry.Key].ValueSuffix = entry.Value.Unit;
                
                LabelLocation.Y += 70;
                textBoxes[entry.Key] = new Label();

                textBoxes[entry.Key].Text = entry.Value.ParameterName;
                textBoxes[entry.Key].Font = new Font("Arial", this.richTextBox1.Font.Size); 

                textBoxes[entry.Key].Location = TextBoxLocation;
                textBoxes[entry.Key].AutoSize = true;
                TextBoxLocation.Y += 70;

                paramnumber[entry.Key] = new Label();
                paramnumber[entry.Key].Text = entry.Value.ParameterNumber;
                paramnumber[entry.Key].Font = new Font("Arial", this.richTextBox1.Font.Size);
                paramnumber[entry.Key].Location = paramnumberlocation;
                paramnumber[entry.Key].AutoSize = true;
                paramnumberlocation.Y += 70;
            }
            for (int i = 1; i < paramcount; i++)
            {
                this.groupPanel1.Controls.Add(labels[i]);
                this.groupPanel1.Controls.Add(textBoxes[i]);
            }
        }

        private void groupPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
