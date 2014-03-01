namespace ArmdroidTools.ArmTest
{
    partial class FormMain
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.contextMenuOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSingleStepCW = new System.Windows.Forms.Button();
            this.btnSingleStepCCW = new System.Windows.Forms.Button();
            this.btnStepMotor = new System.Windows.Forms.Button();
            this.comboMotorChannelSelector = new System.Windows.Forms.ComboBox();
            this.groupMotorControl = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.comboMotorSpeedSelector = new System.Windows.Forms.ComboBox();
            this.txtStepsRequired = new System.Windows.Forms.TextBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblMotorChannel = new System.Windows.Forms.Label();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.lblPortName = new System.Windows.Forms.Label();
            this.contextMenuOutput.SuspendLayout();
            this.groupMotorControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM5";
            this.serialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort_ErrorReceived);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // txtOutput
            // 
            this.txtOutput.ContextMenuStrip = this.contextMenuOutput;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(13, 227);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(651, 243);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TabStop = false;
            // 
            // contextMenuOutput
            // 
            this.contextMenuOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenuItem});
            this.contextMenuOutput.Name = "contextMenuOutput";
            this.contextMenuOutput.Size = new System.Drawing.Size(113, 28);
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(112, 24);
            this.clearMenuItem.Text = "Clear";
            this.clearMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSingleStepCW
            // 
            this.btnSingleStepCW.Location = new System.Drawing.Point(306, 96);
            this.btnSingleStepCW.Name = "btnSingleStepCW";
            this.btnSingleStepCW.Size = new System.Drawing.Size(160, 30);
            this.btnSingleStepCW.TabIndex = 7;
            this.btnSingleStepCW.Text = "Single Step (CW)";
            this.btnSingleStepCW.UseVisualStyleBackColor = true;
            this.btnSingleStepCW.Click += new System.EventHandler(this.btnSingleStepCW_Click);
            // 
            // btnSingleStepCCW
            // 
            this.btnSingleStepCCW.Location = new System.Drawing.Point(484, 96);
            this.btnSingleStepCCW.Name = "btnSingleStepCCW";
            this.btnSingleStepCCW.Size = new System.Drawing.Size(157, 30);
            this.btnSingleStepCCW.TabIndex = 8;
            this.btnSingleStepCCW.Text = "Single Step (CCW)";
            this.btnSingleStepCCW.UseVisualStyleBackColor = true;
            this.btnSingleStepCCW.Click += new System.EventHandler(this.btnSingleStepCCW_Click);
            // 
            // btnStepMotor
            // 
            this.btnStepMotor.Location = new System.Drawing.Point(531, 34);
            this.btnStepMotor.Name = "btnStepMotor";
            this.btnStepMotor.Size = new System.Drawing.Size(110, 30);
            this.btnStepMotor.TabIndex = 4;
            this.btnStepMotor.Text = "Step";
            this.btnStepMotor.UseVisualStyleBackColor = true;
            this.btnStepMotor.Click += new System.EventHandler(this.btnStepMotor_Click);
            // 
            // comboMotorChannelSelector
            // 
            this.comboMotorChannelSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotorChannelSelector.FormattingEnabled = true;
            this.comboMotorChannelSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboMotorChannelSelector.Location = new System.Drawing.Point(131, 39);
            this.comboMotorChannelSelector.Name = "comboMotorChannelSelector";
            this.comboMotorChannelSelector.Size = new System.Drawing.Size(71, 24);
            this.comboMotorChannelSelector.TabIndex = 1;
            this.comboMotorChannelSelector.SelectedIndexChanged += new System.EventHandler(this.comboMotorChannelSelector_SelectedIndexChanged);
            // 
            // groupMotorControl
            // 
            this.groupMotorControl.Controls.Add(this.lblSpeed);
            this.groupMotorControl.Controls.Add(this.comboMotorSpeedSelector);
            this.groupMotorControl.Controls.Add(this.txtStepsRequired);
            this.groupMotorControl.Controls.Add(this.lblSteps);
            this.groupMotorControl.Controls.Add(this.lblMotorChannel);
            this.groupMotorControl.Controls.Add(this.btnSingleStepCW);
            this.groupMotorControl.Controls.Add(this.btnSingleStepCCW);
            this.groupMotorControl.Controls.Add(this.comboMotorChannelSelector);
            this.groupMotorControl.Controls.Add(this.btnStepMotor);
            this.groupMotorControl.Enabled = false;
            this.groupMotorControl.Location = new System.Drawing.Point(13, 69);
            this.groupMotorControl.Name = "groupMotorControl";
            this.groupMotorControl.Size = new System.Drawing.Size(651, 137);
            this.groupMotorControl.TabIndex = 3;
            this.groupMotorControl.TabStop = false;
            this.groupMotorControl.Text = "Motor Control";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(17, 84);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(101, 17);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed (RPM) :";
            // 
            // comboMotorSpeedSelector
            // 
            this.comboMotorSpeedSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotorSpeedSelector.FormattingEnabled = true;
            this.comboMotorSpeedSelector.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "50",
            "100"});
            this.comboMotorSpeedSelector.Location = new System.Drawing.Point(131, 82);
            this.comboMotorSpeedSelector.Name = "comboMotorSpeedSelector";
            this.comboMotorSpeedSelector.Size = new System.Drawing.Size(71, 24);
            this.comboMotorSpeedSelector.TabIndex = 6;
            this.comboMotorSpeedSelector.SelectedIndexChanged += new System.EventHandler(this.comboMotorSpeedSelector_SelectedIndexChanged);
            // 
            // txtStepsRequired
            // 
            this.txtStepsRequired.Location = new System.Drawing.Point(306, 38);
            this.txtStepsRequired.Name = "txtStepsRequired";
            this.txtStepsRequired.Size = new System.Drawing.Size(194, 22);
            this.txtStepsRequired.TabIndex = 3;
            this.txtStepsRequired.TextChanged += new System.EventHandler(this.txtStepsRequired_TextChanged);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(248, 41);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(52, 17);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.Text = "Steps :";
            // 
            // lblMotorChannel
            // 
            this.lblMotorChannel.AutoSize = true;
            this.lblMotorChannel.Location = new System.Drawing.Point(17, 41);
            this.lblMotorChannel.Name = "lblMotorChannel";
            this.lblMotorChannel.Size = new System.Drawing.Size(108, 17);
            this.lblMotorChannel.TabIndex = 0;
            this.lblMotorChannel.Text = "Motor Channel :";
            // 
            // comboPortName
            // 
            this.comboPortName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ArmdroidTools.ArmTest.Properties.Settings.Default, "LastPortUsed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(221, 18);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(156, 24);
            this.comboPortName.TabIndex = 2;
            this.comboPortName.Text = global::ArmdroidTools.ArmTest.Properties.Settings.Default.LastPortUsed;
            this.comboPortName.DropDown += new System.EventHandler(this.comboPortName_DropDown);
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(170, 21);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(42, 17);
            this.lblPortName.TabIndex = 1;
            this.lblPortName.Text = "Port :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 482);
            this.Controls.Add(this.lblPortName);
            this.Controls.Add(this.comboPortName);
            this.Controls.Add(this.groupMotorControl);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armdroid Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.contextMenuOutput.ResumeLayout(false);
            this.groupMotorControl.ResumeLayout(false);
            this.groupMotorControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSingleStepCW;
        private System.Windows.Forms.Button btnSingleStepCCW;
        private System.Windows.Forms.Button btnStepMotor;
        private System.Windows.Forms.ComboBox comboMotorChannelSelector;
        private System.Windows.Forms.GroupBox groupMotorControl;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.Label lblMotorChannel;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.TextBox txtStepsRequired;
        private System.Windows.Forms.ContextMenuStrip contextMenuOutput;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ComboBox comboMotorSpeedSelector;
    }
}

