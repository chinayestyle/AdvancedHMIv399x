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
            this.momentaryButton1 = new AdvancedHMIControls.MomentaryButton();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.groupPanel1 = new AdvancedHMIControls.GroupPanel();
            this.momentaryButton2 = new AdvancedHMIControls.MomentaryButton();
            this.momentaryButton3 = new AdvancedHMIControls.MomentaryButton();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // momentaryButton1
            // 
            this.momentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.momentaryButton1.ComComponent = this.ethernetIPforCLXCom1;
            this.momentaryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.momentaryButton1.Location = new System.Drawing.Point(15, 26);
            this.momentaryButton1.MaximumHoldTime = 3000;
            this.momentaryButton1.MinimumHoldTime = 500;
            this.momentaryButton1.Name = "momentaryButton1";
            this.momentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.momentaryButton1.PLCAddressClick = "";
            this.momentaryButton1.PLCAddressVisible = "";
            this.momentaryButton1.Size = new System.Drawing.Size(155, 164);
            this.momentaryButton1.TabIndex = 0;
            this.momentaryButton1.Text = "START";
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
            // groupPanel1
            // 
            this.groupPanel1.BackColor2 = System.Drawing.Color.Green;
            this.groupPanel1.BackColor3 = System.Drawing.Color.Red;
            this.groupPanel1.ComComponent = this.ethernetIPforCLXCom1;
            this.groupPanel1.Controls.Add(this.momentaryButton3);
            this.groupPanel1.Controls.Add(this.momentaryButton2);
            this.groupPanel1.Controls.Add(this.momentaryButton1);
            this.groupPanel1.Location = new System.Drawing.Point(622, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.SelectBackColor2 = false;
            this.groupPanel1.SelectBackColor3 = false;
            this.groupPanel1.Size = new System.Drawing.Size(591, 221);
            this.groupPanel1.TabIndex = 1;
            // 
            // momentaryButton2
            // 
            this.momentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.momentaryButton2.ComComponent = this.ethernetIPforCLXCom1;
            this.momentaryButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momentaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.momentaryButton2.Location = new System.Drawing.Point(210, 26);
            this.momentaryButton2.MaximumHoldTime = 3000;
            this.momentaryButton2.MinimumHoldTime = 500;
            this.momentaryButton2.Name = "momentaryButton2";
            this.momentaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.momentaryButton2.PLCAddressClick = "";
            this.momentaryButton2.PLCAddressVisible = "";
            this.momentaryButton2.Size = new System.Drawing.Size(155, 164);
            this.momentaryButton2.TabIndex = 1;
            this.momentaryButton2.Text = "STOP";
            // 
            // momentaryButton3
            // 
            this.momentaryButton3.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.momentaryButton3.ComComponent = this.ethernetIPforCLXCom1;
            this.momentaryButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momentaryButton3.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.momentaryButton3.Location = new System.Drawing.Point(406, 26);
            this.momentaryButton3.MaximumHoldTime = 3000;
            this.momentaryButton3.MinimumHoldTime = 500;
            this.momentaryButton3.Name = "momentaryButton3";
            this.momentaryButton3.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.momentaryButton3.PLCAddressClick = "";
            this.momentaryButton3.PLCAddressVisible = "";
            this.momentaryButton3.Size = new System.Drawing.Size(155, 164);
            this.momentaryButton3.TabIndex = 2;
            this.momentaryButton3.Text = "RESET";
            // 
            // D_InitialTorqueSetpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 661);
            this.Controls.Add(this.groupPanel1);
            this.Name = "D_InitialTorqueSetpoint";
            this.Text = "D_InitialTorqueSetpoint";
            this.Load += new System.EventHandler(this.D_InitialTorqueSetpoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedHMIControls.MomentaryButton momentaryButton1;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.GroupPanel groupPanel1;
        private AdvancedHMIControls.MomentaryButton momentaryButton3;
        private AdvancedHMIControls.MomentaryButton momentaryButton2;
    }
}