/*
 * Armdroid Test for Windows
 * 
 * Copyright (C) Richard Morris 2014 - 2020
 * http://armdroid1.blogspot.co.uk
 * 
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ArmdroidTools.ArmTest
{
    public partial class FormMain : Form
    {
        // This delegate enables asynchronous calls for calling
        // AppendText on the TextBox control
        delegate void AppendTextCallback(string text);

        public FormMain()
        {
            InitializeComponent();

            this.comboMotorChannelSelector.SelectedIndex = 0;
            this.comboMotorSpeedSelector.SelectedIndex = 2;   // 15 RPM
        }

        /// <summary>
        /// Thread safe helper to append text to the output control
        /// hosted on the application's U/I thread
        /// </summary>
        /// <param name="text"></param>
        private void AppendOutputText(string text)
        {
            if (this.txtOutput.InvokeRequired)
            {
                AppendTextCallback callback = new AppendTextCallback(AppendOutputText);
                this.Invoke(callback, new object[] { text });
            }
            else
            {
                this.txtOutput.AppendText(text);
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();
            AppendOutputText(data);
        }

        private void serialPort_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            // no error handling yet!
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.BaudRate = 9600;
                    serialPort.PortName = this.comboPortName.Text;
                    serialPort.Encoding = System.Text.Encoding.ASCII;
                    serialPort.NewLine = "\r\n";
                    serialPort.DtrEnable = true;
                    serialPort.Open();
                    serialPort.DiscardInBuffer();
                }
                else
                {
                    serialPort.Close();
                }

                bool connected = serialPort.IsOpen;
                comboPortName.Enabled = !connected;
                groupMotorControl.Enabled = connected;
                btnConnect.Text = connected ? "Disconnect" : "Connect";
            }
            catch (Exception ex)
            {
                MessageBox.Show( this, ex.Message, "Armdroid Test" );
            }
        }

        private void btnStepMotor_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen && txtStepsRequired.Text.Length > 0)
            {
                string stepsRequired = this.txtStepsRequired.Text.Trim();

                // protocol requires negative values to specified with a trailing '-'
                // so we must swap things before sending to the serial stream
                if (stepsRequired[0] == '-')
                {
                    stepsRequired.Remove(0, 1);
                    stepsRequired += "-";
                }

                // channel must be specified with every drive command
                string channel = this.comboMotorChannelSelector.SelectedItem.ToString();

                // issue drive motor command
                serialPort.WriteLine( channel + "," + stepsRequired + "d" );
            }
        }

        private void comboMotorChannelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSingleStepCW_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {

                // channel must be specified with every drive command
                string channel = this.comboMotorChannelSelector.SelectedItem.ToString();

                const string singleStepClockwise = "1d";
                serialPort.WriteLine(channel + "," + singleStepClockwise);
            }
        }

        private void btnSingleStepCCW_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                // channel must be specified with every drive command
                string channel = this.comboMotorChannelSelector.SelectedItem.ToString();

                const string singleStepCounterClockwise = "1-d";
                serialPort.WriteLine(channel + "," + singleStepCounterClockwise);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close serial port on exit
            serialPort.Close();

            // save our application settings
            Properties.Settings.Default.Save();
        }

        private void comboPortName_DropDown(object sender, EventArgs e)
        {
            // enumerate available serial ports
            this.comboPortName.Items.Clear();
            string[] devices = SerialPortEnum.AvailablePorts();
            if (devices != null)
            {
                foreach (string deviceName in devices)
                {
                    this.comboPortName.Items.Add(deviceName);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
        }

        private void comboMotorSpeedSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen && this.comboMotorSpeedSelector.SelectedIndex != -1)
            {
                string speedControl = this.comboMotorSpeedSelector.Items[
                    this.comboMotorSpeedSelector.SelectedIndex ].ToString() + "s";
                serialPort.WriteLine(speedControl);
            }
        }

        private void txtStepsRequired_TextChanged(object sender, EventArgs e)
        {
            this.btnStepMotor.Enabled = this.txtStepsRequired.Text.Length > 0;
        }

    }
}
