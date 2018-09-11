namespace Gen2Training
{
    partial class C_MotorNameplateData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_MotorNameplateData));
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupPanel1 = new AdvancedHMIControls.GroupPanel();
            this.groupPanel2 = new AdvancedHMIControls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel2.SuspendLayout();
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
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(602, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Use the example nameplate data to fill in the corresponding parameters on the ABB" +
    " Drive";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor2 = System.Drawing.Color.Green;
            this.groupPanel1.BackColor3 = System.Drawing.Color.Red;
            this.groupPanel1.ComComponent = this.ethernetIPforCLXCom1;
            this.groupPanel1.Location = new System.Drawing.Point(3, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.SelectBackColor2 = false;
            this.groupPanel1.SelectBackColor3 = false;
            this.groupPanel1.Size = new System.Drawing.Size(323, 701);
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupPanel1_Paint);
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor2 = System.Drawing.Color.Green;
            this.groupPanel2.BackColor3 = System.Drawing.Color.Red;
            this.groupPanel2.ComComponent = this.ethernetIPforCLXCom1;
            this.groupPanel2.Controls.Add(this.richTextBox1);
            this.groupPanel2.Controls.Add(this.pictureBox1);
            this.groupPanel2.Location = new System.Drawing.Point(417, 137);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.SelectBackColor2 = false;
            this.groupPanel2.SelectBackColor3 = false;
            this.groupPanel2.Size = new System.Drawing.Size(847, 508);
            this.groupPanel2.TabIndex = 3;
            // 
            // C_MotorNameplateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 820);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "C_MotorNameplateData";
            this.Text = "C_MotorNameplateData";
            this.Load += new System.EventHandler(this.C_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AdvancedHMIControls.GroupPanel groupPanel1;
        private AdvancedHMIControls.GroupPanel groupPanel2;
    }
}