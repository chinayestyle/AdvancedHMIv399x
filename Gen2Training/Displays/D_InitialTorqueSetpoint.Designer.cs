namespace Gen2Training
{
    partial class D_InitialTorqueSetpoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D_InitialTorqueSetpoint));
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BasicLabel3 = new AdvancedHMIControls.BasicLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "172.16.30.55";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BasicLabel3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(29, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torque Setpoint";
            // 
            // BasicLabel3
            // 
            this.BasicLabel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel3.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel3.DisplayAsTime = false;
            this.BasicLabel3.Font = new System.Drawing.Font("Siemens AD Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel3.Highlight = false;
            this.BasicLabel3.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel3.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel3.HighlightKeyCharacter = "!";
            this.BasicLabel3.InterpretValueAsBCD = false;
            this.BasicLabel3.KeypadAlphaNumeric = false;
            this.BasicLabel3.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel3.KeypadMaxValue = 150D;
            this.BasicLabel3.KeypadMinValue = 0D;
            this.BasicLabel3.KeypadScaleFactor = 1D;
            this.BasicLabel3.KeypadShowCurrentValue = false;
            this.BasicLabel3.KeypadText = null;
            this.BasicLabel3.KeypadWidth = 300;
            this.BasicLabel3.Location = new System.Drawing.Point(13, 55);
            this.BasicLabel3.Name = "BasicLabel3";
            this.BasicLabel3.NumericFormat = null;
            this.BasicLabel3.PLCAddressKeypad = "Gen_II_Control_Parameters.Torque_Setpoint";
            this.BasicLabel3.PLCAddressValue = "Gen_II_Control_Parameters.Torque_Setpoint";
            this.BasicLabel3.PollRate = 0;
            this.BasicLabel3.Size = new System.Drawing.Size(87, 84);
            this.BasicLabel3.TabIndex = 13;
            this.BasicLabel3.Text = "0 %";
            this.BasicLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel3.Value = "0";
            this.BasicLabel3.ValueLeftPadCharacter = ' ';
            this.BasicLabel3.ValueLeftPadLength = 0;
            this.BasicLabel3.ValuePrefix = null;
            this.BasicLabel3.ValueScaleFactor = 1D;
            this.BasicLabel3.ValueSuffix = " %";
            this.BasicLabel3.ValueToSubtractFrom = 0F;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(262, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commissioning Instructions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 124);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(923, 54);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Use the information from the previous step, and the chart below to define an init" +
    "ial torque setpoint. Enter the value in the Box labeled \"Torque Setpoint\" on the" +
    " left, and open the VFD tools above.";
            // 
            // D_InitialTorqueSetpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "D_InitialTorqueSetpoint";
            this.Text = "D_InitialTorqueSetpoint";
            this.Load += new System.EventHandler(this.D_InitialTorqueSetpoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        internal AdvancedHMIControls.BasicLabel BasicLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}