using System;
using System.Co
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        private string inData;
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e) {
            serialPort1.WriteLine(sendTextBox.Text);
            sendTextBox.Text = "";
            sendTextBox.Focus();
        }

        private void openPort_Click(object sender, EventArgs e) {
            try
            {
                if(portComboBox.Text==""||baudComboBox.Text=="") {
                    MessageBox.Show("Please select port settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    serialPort1.PortName = portComboBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudComboBox.Text);
                    serialPort1.Open();
                    if(serialPort1.IsOpen) {
                        send.Enabled = true;
                        reciveTextBox.Enabled = true;
                        sendTextBox.Enabled = true;
                        hexTextBox.Enabled = true;
                        closePort.Enabled = true;
                        autoScrollCheckBox.Enabled = true;
                        openPort.Enabled = false;
                        portComboBox.Enabled = false;
                        baudComboBox.Enabled = false;
                    }


                }
            }
            catch(UnauthorizedAccessException) {
                MessageBox.Show("Unauthorized Access!", "Port Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closePort_Click(object sender, EventArgs e) {
            serialPort1.Close();
            reciveTextBox.Text = "";
            hexTextBox.Text = "";
            sendTextBox.Text = "";
            send.Enabled = false;
            closePort.Enabled = false;
            reciveTextBox.Enabled = false;
            sendTextBox.Enabled = false;
            hexTextBox.Enabled = false;
            autoScrollCheckBox.Enabled = false;
            portComboBox.Enabled = true;
            openPort.Enabled = true;
            baudComboBox.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if(serialPort1.IsOpen)
            serialPort1.Close();
            Application.ExitThread();
        }

        private void sendTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
            {
                serialPort1.WriteLine(sendTextBox.Text);
                sendTextBox.Text = "";
                sendTextBox.Clear();
                sendTextBox.Focus();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            inData = serialPort1.ReadExisting();

            this.Invoke(new EventHandler(recivedData));
        }

        private void recivedData(object sender, EventArgs e) {
            reciveTextBox.AppendText(inData);

            byte[] bt = Encoding.Default.GetBytes(inData);
            var hexString = BitConverter.ToString(bt);
            hexString = hexString.Replace("-", " ");
            hexTextBox.AppendText(hexString);
            if (inData.EndsWith("\r\n")) {
                hexTextBox.AppendText(System.Environment.NewLine);
            } else if (inData.EndsWith("\n")) {
                hexTextBox.AppendText(System.Environment.NewLine);
            }

        }

        private void reciveTextBox_TextChanged(object sender, EventArgs e) {
            if (autoScrollCheckBox.Checked) {
                reciveTextBox.SelectionStart = reciveTextBox.Text.Length;
                reciveTextBox.ScrollToCaret();
                hexTextBox.SelectionStart = reciveTextBox.Text.Length;
                hexTextBox.ScrollToCaret();
            }
        }

        private void portComboBox_MouseClick(object sender, MouseEventArgs e) {
            string[] ports = SerialPort.GetPortNames();
            portComboBox.Items.Clear();
            portComboBox.Items.AddRange(ports);
        }
    }
}
