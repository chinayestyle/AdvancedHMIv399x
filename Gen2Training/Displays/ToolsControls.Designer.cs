namespace Gen2Training.Displays
{
    partial class ToolsControls
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
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.BasicLabel7 = new AdvancedHMIControls.BasicLabel();
            this.BasicLabel1 = new AdvancedHMIControls.BasicLabel();
            this.LblMainSPDisp = new AdvancedHMIControls.BasicLabel();
            this.LblMainSpeedMan = new AdvancedHMIControls.BasicLabel();
            this.LblMainRetention = new AdvancedHMIControls.BasicLabel();
            this.BasicLabel6 = new AdvancedHMIControls.BasicLabel();
            this.BasicLabel8 = new AdvancedHMIControls.BasicLabel();
            this.ThreeButtonPLC1 = new AdvancedHMIControls.ThreeButtonPLC();
            this.MbStop = new AdvancedHMIControls.MomentaryButton();
            this.BasicLabel9 = new AdvancedHMIControls.BasicLabel();
            this.MbStart = new AdvancedHMIControls.MomentaryButton();
            this.MbReset = new AdvancedHMIControls.MomentaryButton();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
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
            // BasicLabel7
            // 
            this.BasicLabel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel7.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel7.DisplayAsTime = false;
            this.BasicLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BasicLabel7.ForeColor = System.Drawing.Color.AliceBlue;
            this.BasicLabel7.Highlight = false;
            this.BasicLabel7.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel7.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel7.HighlightKeyCharacter = "!";
            this.BasicLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasicLabel7.InterpretValueAsBCD = false;
            this.BasicLabel7.KeypadAlphaNumeric = false;
            this.BasicLabel7.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel7.KeypadMaxValue = 0D;
            this.BasicLabel7.KeypadMinValue = 0D;
            this.BasicLabel7.KeypadScaleFactor = 1D;
            this.BasicLabel7.KeypadShowCurrentValue = false;
            this.BasicLabel7.KeypadText = null;
            this.BasicLabel7.KeypadWidth = 300;
            this.BasicLabel7.Location = new System.Drawing.Point(269, 355);
            this.BasicLabel7.Name = "BasicLabel7";
            this.BasicLabel7.NumericFormat = null;
            this.BasicLabel7.PLCAddressKeypad = "";
            this.BasicLabel7.PollRate = 0;
            this.BasicLabel7.Size = new System.Drawing.Size(202, 39);
            this.BasicLabel7.TabIndex = 268;
            this.BasicLabel7.Text = "TENSION SETPOINT";
            this.BasicLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel7.Value = "TENSION SETPOINT";
            this.BasicLabel7.ValueLeftPadCharacter = ' ';
            this.BasicLabel7.ValueLeftPadLength = 0;
            this.BasicLabel7.ValuePrefix = null;
            this.BasicLabel7.ValueScaleFactor = 1D;
            this.BasicLabel7.ValueSuffix = null;
            this.BasicLabel7.ValueToSubtractFrom = 0F;
            // 
            // BasicLabel1
            // 
            this.BasicLabel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel1.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel1.DisplayAsTime = false;
            this.BasicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BasicLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel1.Highlight = false;
            this.BasicLabel1.HighlightColor = System.Drawing.Color.Green;
            this.BasicLabel1.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel1.HighlightKeyCharacter = "!";
            this.BasicLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasicLabel1.InterpretValueAsBCD = false;
            this.BasicLabel1.KeypadAlphaNumeric = false;
            this.BasicLabel1.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel1.KeypadMaxValue = 0D;
            this.BasicLabel1.KeypadMinValue = 0D;
            this.BasicLabel1.KeypadScaleFactor = 1D;
            this.BasicLabel1.KeypadShowCurrentValue = false;
            this.BasicLabel1.KeypadText = null;
            this.BasicLabel1.KeypadWidth = 300;
            this.BasicLabel1.Location = new System.Drawing.Point(33, 394);
            this.BasicLabel1.Name = "BasicLabel1";
            this.BasicLabel1.NumericFormat = "f";
            this.BasicLabel1.PLCAddressKeypad = "";
            this.BasicLabel1.PLCAddressValue = "Load_Cell_Percent";
            this.BasicLabel1.PollRate = 0;
            this.BasicLabel1.Size = new System.Drawing.Size(202, 53);
            this.BasicLabel1.SuppressErrorDisplay = true;
            this.BasicLabel1.TabIndex = 271;
            this.BasicLabel1.Text = " %";
            this.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel1.Value = "";
            this.BasicLabel1.ValueLeftPadCharacter = ' ';
            this.BasicLabel1.ValueLeftPadLength = 0;
            this.BasicLabel1.ValuePrefix = null;
            this.BasicLabel1.ValueScaleFactor = 1D;
            this.BasicLabel1.ValueSuffix = " %";
            this.BasicLabel1.ValueToSubtractFrom = 0F;
            // 
            // LblMainSPDisp
            // 
            this.LblMainSPDisp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LblMainSPDisp.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.LblMainSPDisp.ComComponent = this.ethernetIPforCLXCom1;
            this.LblMainSPDisp.DisplayAsTime = false;
            this.LblMainSPDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblMainSPDisp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblMainSPDisp.Highlight = false;
            this.LblMainSPDisp.HighlightColor = System.Drawing.Color.Red;
            this.LblMainSPDisp.HighlightForeColor = System.Drawing.Color.White;
            this.LblMainSPDisp.HighlightKeyCharacter = "!";
            this.LblMainSPDisp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMainSPDisp.InterpretValueAsBCD = false;
            this.LblMainSPDisp.KeypadAlphaNumeric = false;
            this.LblMainSPDisp.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.LblMainSPDisp.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainSPDisp.KeypadMaxValue = 200D;
            this.LblMainSPDisp.KeypadMinValue = 0D;
            this.LblMainSPDisp.KeypadScaleFactor = 1D;
            this.LblMainSPDisp.KeypadShowCurrentValue = false;
            this.LblMainSPDisp.KeypadText = null;
            this.LblMainSPDisp.KeypadWidth = 300;
            this.LblMainSPDisp.Location = new System.Drawing.Point(269, 394);
            this.LblMainSPDisp.Name = "LblMainSPDisp";
            this.LblMainSPDisp.NumericFormat = "f";
            this.LblMainSPDisp.PLCAddressKeypad = "Gen_II_Control_Parameters.Torque_Setpoint";
            this.LblMainSPDisp.PLCAddressValue = "Gen_II_Control_Parameters.Torque_Setpoint";
            this.LblMainSPDisp.PollRate = 0;
            this.LblMainSPDisp.Size = new System.Drawing.Size(202, 53);
            this.LblMainSPDisp.SuppressErrorDisplay = true;
            this.LblMainSPDisp.TabIndex = 264;
            this.LblMainSPDisp.Text = " %";
            this.LblMainSPDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMainSPDisp.Value = "";
            this.LblMainSPDisp.ValueLeftPadCharacter = ' ';
            this.LblMainSPDisp.ValueLeftPadLength = 0;
            this.LblMainSPDisp.ValuePrefix = null;
            this.LblMainSPDisp.ValueScaleFactor = 1D;
            this.LblMainSPDisp.ValueSuffix = " %";
            this.LblMainSPDisp.ValueToSubtractFrom = 0F;
            // 
            // LblMainSpeedMan
            // 
            this.LblMainSpeedMan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LblMainSpeedMan.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.LblMainSpeedMan.ComComponent = this.ethernetIPforCLXCom1;
            this.LblMainSpeedMan.DisplayAsTime = false;
            this.LblMainSpeedMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblMainSpeedMan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblMainSpeedMan.Highlight = false;
            this.LblMainSpeedMan.HighlightColor = System.Drawing.Color.Green;
            this.LblMainSpeedMan.HighlightForeColor = System.Drawing.Color.White;
            this.LblMainSpeedMan.HighlightKeyCharacter = "!";
            this.LblMainSpeedMan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMainSpeedMan.InterpretValueAsBCD = false;
            this.LblMainSpeedMan.KeypadAlphaNumeric = false;
            this.LblMainSpeedMan.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.LblMainSpeedMan.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainSpeedMan.KeypadMaxValue = 80D;
            this.LblMainSpeedMan.KeypadMinValue = 0D;
            this.LblMainSpeedMan.KeypadScaleFactor = 1D;
            this.LblMainSpeedMan.KeypadShowCurrentValue = false;
            this.LblMainSpeedMan.KeypadText = null;
            this.LblMainSpeedMan.KeypadWidth = 300;
            this.LblMainSpeedMan.Location = new System.Drawing.Point(33, 296);
            this.LblMainSpeedMan.Name = "LblMainSpeedMan";
            this.LblMainSpeedMan.NumericFormat = "F";
            this.LblMainSpeedMan.PLCAddressKeypad = "HMI_Frequency_Setting";
            this.LblMainSpeedMan.PLCAddressValue = "HMI_Frequency_Setting";
            this.LblMainSpeedMan.PLCAddressVisible = "hand_mode";
            this.LblMainSpeedMan.PollRate = 0;
            this.LblMainSpeedMan.Size = new System.Drawing.Size(202, 50);
            this.LblMainSpeedMan.SuppressErrorDisplay = true;
            this.LblMainSpeedMan.TabIndex = 265;
            this.LblMainSpeedMan.Text = " Hz";
            this.LblMainSpeedMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMainSpeedMan.Value = "";
            this.LblMainSpeedMan.ValueLeftPadCharacter = ' ';
            this.LblMainSpeedMan.ValueLeftPadLength = 0;
            this.LblMainSpeedMan.ValuePrefix = null;
            this.LblMainSpeedMan.ValueScaleFactor = 1D;
            this.LblMainSpeedMan.ValueSuffix = " Hz";
            this.LblMainSpeedMan.ValueToSubtractFrom = 0F;
            // 
            // LblMainRetention
            // 
            this.LblMainRetention.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LblMainRetention.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.LblMainRetention.ComComponent = this.ethernetIPforCLXCom1;
            this.LblMainRetention.DisplayAsTime = false;
            this.LblMainRetention.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LblMainRetention.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblMainRetention.Highlight = false;
            this.LblMainRetention.HighlightColor = System.Drawing.Color.Green;
            this.LblMainRetention.HighlightForeColor = System.Drawing.Color.White;
            this.LblMainRetention.HighlightKeyCharacter = "!";
            this.LblMainRetention.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMainRetention.InterpretValueAsBCD = false;
            this.LblMainRetention.KeypadAlphaNumeric = false;
            this.LblMainRetention.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.LblMainRetention.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainRetention.KeypadMaxValue = 80D;
            this.LblMainRetention.KeypadMinValue = 0D;
            this.LblMainRetention.KeypadScaleFactor = 1D;
            this.LblMainRetention.KeypadShowCurrentValue = false;
            this.LblMainRetention.KeypadText = null;
            this.LblMainRetention.KeypadWidth = 300;
            this.LblMainRetention.Location = new System.Drawing.Point(269, 296);
            this.LblMainRetention.Name = "LblMainRetention";
            this.LblMainRetention.NumericFormat = "f";
            this.LblMainRetention.PLCAddressKeypad = "Spiral_Drum.Retention.Target_Retention_Time";
            this.LblMainRetention.PLCAddressValue = "Spiral_Drum.Retention.Target_Retention_Time";
            this.LblMainRetention.PLCAddressVisible = "auto_mode";
            this.LblMainRetention.PollRate = 0;
            this.LblMainRetention.Size = new System.Drawing.Size(202, 50);
            this.LblMainRetention.SuppressErrorDisplay = true;
            this.LblMainRetention.TabIndex = 263;
            this.LblMainRetention.Text = " Minutes";
            this.LblMainRetention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMainRetention.Value = "";
            this.LblMainRetention.ValueLeftPadCharacter = ' ';
            this.LblMainRetention.ValueLeftPadLength = 0;
            this.LblMainRetention.ValuePrefix = null;
            this.LblMainRetention.ValueScaleFactor = 1D;
            this.LblMainRetention.ValueSuffix = " Minutes";
            this.LblMainRetention.ValueToSubtractFrom = 0F;
            // 
            // BasicLabel6
            // 
            this.BasicLabel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel6.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel6.DisplayAsTime = false;
            this.BasicLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BasicLabel6.ForeColor = System.Drawing.Color.AliceBlue;
            this.BasicLabel6.Highlight = false;
            this.BasicLabel6.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel6.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel6.HighlightKeyCharacter = "!";
            this.BasicLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasicLabel6.InterpretValueAsBCD = false;
            this.BasicLabel6.KeypadAlphaNumeric = false;
            this.BasicLabel6.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel6.KeypadMaxValue = 0D;
            this.BasicLabel6.KeypadMinValue = 0D;
            this.BasicLabel6.KeypadScaleFactor = 1D;
            this.BasicLabel6.KeypadShowCurrentValue = false;
            this.BasicLabel6.KeypadText = null;
            this.BasicLabel6.KeypadWidth = 300;
            this.BasicLabel6.Location = new System.Drawing.Point(269, 257);
            this.BasicLabel6.Name = "BasicLabel6";
            this.BasicLabel6.NumericFormat = null;
            this.BasicLabel6.PLCAddressKeypad = "";
            this.BasicLabel6.PLCAddressVisible = "auto_mode";
            this.BasicLabel6.PollRate = 0;
            this.BasicLabel6.Size = new System.Drawing.Size(202, 39);
            this.BasicLabel6.TabIndex = 267;
            this.BasicLabel6.Text = "RETENTION TIME";
            this.BasicLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel6.Value = "RETENTION TIME";
            this.BasicLabel6.ValueLeftPadCharacter = ' ';
            this.BasicLabel6.ValueLeftPadLength = 0;
            this.BasicLabel6.ValuePrefix = null;
            this.BasicLabel6.ValueScaleFactor = 1D;
            this.BasicLabel6.ValueSuffix = null;
            this.BasicLabel6.ValueToSubtractFrom = 0F;
            // 
            // BasicLabel8
            // 
            this.BasicLabel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel8.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel8.DisplayAsTime = false;
            this.BasicLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BasicLabel8.ForeColor = System.Drawing.Color.AliceBlue;
            this.BasicLabel8.Highlight = false;
            this.BasicLabel8.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel8.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel8.HighlightKeyCharacter = "!";
            this.BasicLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasicLabel8.InterpretValueAsBCD = false;
            this.BasicLabel8.KeypadAlphaNumeric = false;
            this.BasicLabel8.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel8.KeypadMaxValue = 0D;
            this.BasicLabel8.KeypadMinValue = 0D;
            this.BasicLabel8.KeypadScaleFactor = 1D;
            this.BasicLabel8.KeypadShowCurrentValue = false;
            this.BasicLabel8.KeypadText = null;
            this.BasicLabel8.KeypadWidth = 300;
            this.BasicLabel8.Location = new System.Drawing.Point(33, 257);
            this.BasicLabel8.Name = "BasicLabel8";
            this.BasicLabel8.NumericFormat = null;
            this.BasicLabel8.PLCAddressKeypad = "";
            this.BasicLabel8.PLCAddressVisible = "hand_mode";
            this.BasicLabel8.PollRate = 0;
            this.BasicLabel8.Size = new System.Drawing.Size(202, 39);
            this.BasicLabel8.TabIndex = 269;
            this.BasicLabel8.Text = "MANUAL SPEED";
            this.BasicLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel8.Value = "MANUAL SPEED";
            this.BasicLabel8.ValueLeftPadCharacter = ' ';
            this.BasicLabel8.ValueLeftPadLength = 0;
            this.BasicLabel8.ValuePrefix = null;
            this.BasicLabel8.ValueScaleFactor = 1D;
            this.BasicLabel8.ValueSuffix = null;
            this.BasicLabel8.ValueToSubtractFrom = 0F;
            // 
            // ThreeButtonPLC1
            // 
            this.ThreeButtonPLC1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ThreeButtonPLC1.Button1Text = "Manual";
            this.ThreeButtonPLC1.Button2Text = "Auto";
            this.ThreeButtonPLC1.Button3Text = "Test";
            this.ThreeButtonPLC1.ComComponent = this.ethernetIPforCLXCom1;
            this.ThreeButtonPLC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.ThreeButtonPLC1.Location = new System.Drawing.Point(926, 164);
            this.ThreeButtonPLC1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ThreeButtonPLC1.Name = "ThreeButtonPLC1";
            this.ThreeButtonPLC1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.ThreeButtonPLC1.PLCAddressClickAuto = "HMI_Auto_Mode";
            this.ThreeButtonPLC1.PLCAddressClickHand = "HMI_Hand_Mode";
            this.ThreeButtonPLC1.PLCAddressClickOff = "HMI_Test_Mode";
            this.ThreeButtonPLC1.PLCAddressStatusAuto = "Auto_Mode";
            this.ThreeButtonPLC1.PLCAddressStatusHand = "Hand_Mode";
            this.ThreeButtonPLC1.PLCAddressStatusOff = "Test_Mode";
            this.ThreeButtonPLC1.PLCAddressVisible = "";
            this.ThreeButtonPLC1.Size = new System.Drawing.Size(239, 303);
            this.ThreeButtonPLC1.TabIndex = 266;
            // 
            // MbStop
            // 
            this.MbStop.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.MbStop.ComComponent = this.ethernetIPforCLXCom1;
            this.MbStop.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 14F, System.Drawing.FontStyle.Bold);
            this.MbStop.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.MbStop.Location = new System.Drawing.Point(211, 41);
            this.MbStop.MaximumHoldTime = 3000;
            this.MbStop.MinimumHoldTime = 500;
            this.MbStop.Name = "MbStop";
            this.MbStop.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.MbStop.PLCAddressClick = "HMI.Stop";
            this.MbStop.PLCAddressVisible = "";
            this.MbStop.Size = new System.Drawing.Size(164, 173);
            this.MbStop.TabIndex = 261;
            this.MbStop.Text = "STOP";
            // 
            // BasicLabel9
            // 
            this.BasicLabel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.BasicLabel9.ComComponent = this.ethernetIPforCLXCom1;
            this.BasicLabel9.DisplayAsTime = false;
            this.BasicLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BasicLabel9.ForeColor = System.Drawing.Color.AliceBlue;
            this.BasicLabel9.Highlight = false;
            this.BasicLabel9.HighlightColor = System.Drawing.Color.Red;
            this.BasicLabel9.HighlightForeColor = System.Drawing.Color.White;
            this.BasicLabel9.HighlightKeyCharacter = "!";
            this.BasicLabel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BasicLabel9.InterpretValueAsBCD = false;
            this.BasicLabel9.KeypadAlphaNumeric = false;
            this.BasicLabel9.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.BasicLabel9.KeypadMaxValue = 0D;
            this.BasicLabel9.KeypadMinValue = 0D;
            this.BasicLabel9.KeypadScaleFactor = 1D;
            this.BasicLabel9.KeypadShowCurrentValue = false;
            this.BasicLabel9.KeypadText = null;
            this.BasicLabel9.KeypadWidth = 300;
            this.BasicLabel9.Location = new System.Drawing.Point(33, 355);
            this.BasicLabel9.Name = "BasicLabel9";
            this.BasicLabel9.NumericFormat = null;
            this.BasicLabel9.PLCAddressKeypad = "";
            this.BasicLabel9.PollRate = 0;
            this.BasicLabel9.Size = new System.Drawing.Size(202, 39);
            this.BasicLabel9.TabIndex = 270;
            this.BasicLabel9.Text = "LOAD CELL";
            this.BasicLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BasicLabel9.Value = "LOAD CELL";
            this.BasicLabel9.ValueLeftPadCharacter = ' ';
            this.BasicLabel9.ValueLeftPadLength = 0;
            this.BasicLabel9.ValuePrefix = null;
            this.BasicLabel9.ValueScaleFactor = 1D;
            this.BasicLabel9.ValueSuffix = null;
            this.BasicLabel9.ValueToSubtractFrom = 0F;
            // 
            // MbStart
            // 
            this.MbStart.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.MbStart.ComComponent = this.ethernetIPforCLXCom1;
            this.MbStart.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 14F, System.Drawing.FontStyle.Bold);
            this.MbStart.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.MbStart.Location = new System.Drawing.Point(12, 41);
            this.MbStart.MaximumHoldTime = 3000;
            this.MbStart.MinimumHoldTime = 500;
            this.MbStart.Name = "MbStart";
            this.MbStart.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.MbStart.PLCAddressClick = "HMI.Start";
            this.MbStart.PLCAddressVisible = "";
            this.MbStart.Size = new System.Drawing.Size(164, 173);
            this.MbStart.TabIndex = 260;
            this.MbStart.Text = "START";
            // 
            // MbReset
            // 
            this.MbReset.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.MbReset.ComComponent = this.ethernetIPforCLXCom1;
            this.MbReset.Font = new System.Drawing.Font("Siemens TIA Portal Basic", 14F, System.Drawing.FontStyle.Bold);
            this.MbReset.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small;
            this.MbReset.Location = new System.Drawing.Point(398, 41);
            this.MbReset.MaximumHoldTime = 3000;
            this.MbReset.MinimumHoldTime = 500;
            this.MbReset.Name = "MbReset";
            this.MbReset.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.MbReset.PLCAddressClick = "HMI.Fault_Reset_Main";
            this.MbReset.PLCAddressVisible = "";
            this.MbReset.Size = new System.Drawing.Size(164, 173);
            this.MbReset.TabIndex = 262;
            this.MbReset.Text = "RESET";
            // 
            // ToolsControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 555);
            this.Controls.Add(this.BasicLabel7);
            this.Controls.Add(this.BasicLabel1);
            this.Controls.Add(this.LblMainSPDisp);
            this.Controls.Add(this.LblMainSpeedMan);
            this.Controls.Add(this.LblMainRetention);
            this.Controls.Add(this.BasicLabel6);
            this.Controls.Add(this.BasicLabel8);
            this.Controls.Add(this.ThreeButtonPLC1);
            this.Controls.Add(this.MbStop);
            this.Controls.Add(this.BasicLabel9);
            this.Controls.Add(this.MbStart);
            this.Controls.Add(this.MbReset);
            this.Name = "ToolsControls";
            this.Text = "ToolsControls";
            this.Load += new System.EventHandler(this.Load_toolscontrols);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        internal AdvancedHMIControls.BasicLabel BasicLabel7;
        internal AdvancedHMIControls.BasicLabel BasicLabel1;
        internal AdvancedHMIControls.BasicLabel LblMainSPDisp;
        internal AdvancedHMIControls.BasicLabel LblMainSpeedMan;
        internal AdvancedHMIControls.BasicLabel LblMainRetention;
        internal AdvancedHMIControls.BasicLabel BasicLabel6;
        internal AdvancedHMIControls.BasicLabel BasicLabel8;
        internal AdvancedHMIControls.ThreeButtonPLC ThreeButtonPLC1;
        internal AdvancedHMIControls.MomentaryButton MbStop;
        internal AdvancedHMIControls.BasicLabel BasicLabel9;
        internal AdvancedHMIControls.MomentaryButton MbStart;
        internal AdvancedHMIControls.MomentaryButton MbReset;
    }
}