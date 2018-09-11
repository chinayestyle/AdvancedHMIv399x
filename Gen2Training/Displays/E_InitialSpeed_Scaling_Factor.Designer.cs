namespace Gen2Training
{
    partial class E_InitialSpeed_Scaling_Factor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_InitialSpeed_Scaling_Factor));
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BasicLabel1 = new AdvancedHMIControls.BasicLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gen2Training.Properties.Resources.tuspeedscalingfactor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BasicLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox2.Location = new System.Drawing.Point(24, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 147);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initial Takeup Scaling Factor";
            // 
            // BasicLabel1
            // 
            this.BasicLabel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel1.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel1.DisplayAsTime = false;
            this.BasicLabel1.Font = new System.Drawing.Font("Siemens AD Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel1.Highlight = false;
            this.BasicLabel1.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel1.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel1.HighlightKeyCharacter = "!";
            this.BasicLabel1.InterpretValueAsBCD = false;
            this.BasicLabel1.KeypadAlphaNumeric = false;
            this.BasicLabel1.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel1.KeypadMaxValue = 2900D;
            this.BasicLabel1.KeypadMinValue = 0D;
            this.BasicLabel1.KeypadScaleFactor = 1D;
            this.BasicLabel1.KeypadShowCurrentValue = false;
            this.BasicLabel1.KeypadText = null;
            this.BasicLabel1.KeypadWidth = 300;
            this.BasicLabel1.Location = new System.Drawing.Point(30, 60);
            this.BasicLabel1.Name = "BasicLabel1";
            this.BasicLabel1.NumericFormat = null;
            this.BasicLabel1.PLCAddressKeypad = "HMI.Tension_Control.Speed_Reference_Scaling";
            this.BasicLabel1.PLCAddressValue = "HMI.Tension_Control.Speed_Reference_Scaling";
            this.BasicLabel1.PollRate = 0;
            this.BasicLabel1.Size = new System.Drawing.Size(87, 84);
            this.BasicLabel1.TabIndex = 10;
            this.BasicLabel1.Text = "0 rpm";
            this.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel1.Value = "0";
            this.BasicLabel1.ValueLeftPadCharacter = ' ';
            this.BasicLabel1.ValueLeftPadLength = 0;
            this.BasicLabel1.ValuePrefix = null;
            this.BasicLabel1.ValueScaleFactor = 1D;
            this.BasicLabel1.ValueSuffix = " rpm";
            this.BasicLabel1.ValueToSubtractFrom = 0F;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(290, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 207);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commissioning Instructions";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(791, 90);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // E_InitialSpeed_Scaling_Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "E_InitialSpeed_Scaling_Factor";
            this.Text = "E_InitialSpeed_Scaling_Factor";
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal AdvancedHMIControls.BasicLabel BasicLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}