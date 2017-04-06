namespace Serial_Communication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sendBox = new System.Windows.Forms.GroupBox();
            this.send = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.RichTextBox();
            this.reciveBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reciveTextBox = new System.Windows.Forms.RichTextBox();
            this.hexTextBox = new System.Windows.Forms.RichTextBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.openPort = new System.Windows.Forms.Button();
            this.closePort = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.autoScrollCheckBox = new System.Windows.Forms.CheckBox();
            this.sendBox.SuspendLayout();
            this.reciveBox.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendBox
            // 
            this.sendBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBox.Controls.Add(this.send);
            this.sendBox.Controls.Add(this.sendTextBox);
            this.sendBox.Location = new System.Drawing.Point(12, 8);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(721, 47);
            this.sendBox.TabIndex = 0;
            this.sendBox.TabStop = false;
            this.sendBox.Text = "Send";
            // 
            // send
            // 
            this.send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.send.Enabled = false;
            this.send.Location = new System.Drawing.Point(640, 16);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendTextBox.Enabled = false;
            this.sendTextBox.Location = new System.Drawing.Point(6, 18);
            this.sendTextBox.Multiline = false;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(628, 21);
            this.sendTextBox.TabIndex = 0;
            this.sendTextBox.Text = "";
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendTextBox_KeyDown);
            // 
            // reciveBox
            // 
            this.reciveBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveBox.Controls.Add(this.splitContainer1);
            this.reciveBox.Location = new System.Drawing.Point(12, 59);
            this.reciveBox.Name = "reciveBox";
            this.reciveBox.Size = new System.Drawing.Size(721, 280);
            this.reciveBox.TabIndex = 1;
            this.reciveBox.TabStop = false;
            this.reciveBox.Text = "Recive";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.reciveTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hexTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(715, 261);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 3;
            // 
            // reciveTextBox
            // 
            this.reciveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciveTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reciveTextBox.Enabled = false;
            this.reciveTextBox.Location = new System.Drawing.Point(0, 0);
            this.reciveTextBox.Name = "reciveTextBox";
            this.reciveTextBox.ReadOnly = true;
            this.reciveTextBox.Size = new System.Drawing.Size(335, 261);
            this.reciveTextBox.TabIndex = 1;
            this.reciveTextBox.Text = "";
            this.reciveTextBox.WordWrap = false;
            this.reciveTextBox.TextChanged += new System.EventHandler(this.reciveTextBox_TextChanged);
            // 
            // hexTextBox
            // 
            this.hexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexTextBox.Enabled = false;
            this.hexTextBox.Location = new System.Drawing.Point(0, 0);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.Size = new System.Drawing.Size(376, 261);
            this.hexTextBox.TabIndex = 2;
            this.hexTextBox.Text = "";
            this.hexTextBox.WordWrap = false;
            // 
            // portComboBox
            // 
            this.portComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(12, 361);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(127, 21);
            this.portComboBox.TabIndex = 2;
            this.portComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portComboBox_MouseClick);
            // 
            // baudComboBox
            // 
            this.baudComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudComboBox.Location = new System.Drawing.Point(144, 361);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(127, 21);
            this.baudComboBox.TabIndex = 3;
            // 
            // openPort
            // 
            this.openPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openPort.Location = new System.Drawing.Point(545, 359);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(91, 23);
            this.openPort.TabIndex = 5;
            this.openPort.Text = "Connect";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // closePort
            // 
            this.closePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closePort.Enabled = false;
            this.closePort.Location = new System.Drawing.Point(642, 359);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(91, 23);
            this.closePort.TabIndex = 6;
            this.closePort.Text = "Disconnect";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // comPort
            // 
            this.comPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comPort.AutoSize = true;
            this.comPort.Location = new System.Drawing.Point(9, 345);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(53, 13);
            this.comPort.TabIndex = 7;
            this.comPort.Text = "COM Port";
            // 
            // baudRate
            // 
            this.baudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baudRate.AutoSize = true;
            this.baudRate.Location = new System.Drawing.Point(142, 345);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(58, 13);
            this.baudRate.TabIndex = 8;
            this.baudRate.Text = "Baud Rate";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // autoScrollCheckBox
            // 
            this.autoScrollCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoScrollCheckBox.AutoSize = true;
            this.autoScrollCheckBox.Enabled = false;
            this.autoScrollCheckBox.Location = new System.Drawing.Point(277, 363);
            this.autoScrollCheckBox.Name = "autoScrollCheckBox";
            this.autoScrollCheckBox.Size = new System.Drawing.Size(77, 17);
            this.autoScrollCheckBox.TabIndex = 10;
            this.autoScrollCheckBox.Text = "Auto Scroll";
            this.autoScrollCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 392);
            this.Controls.Add(this.autoScrollCheckBox);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.baudComboBox);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.reciveBox);
            this.Controls.Add(this.sendBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(761, 431);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.sendBox.ResumeLayout(false);
            this.reciveBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sendBox;
        private System.Windows.Forms.GroupBox reciveBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox sendTextBox;
        private System.Windows.Forms.RichTextBox reciveTextBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.Label baudRate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox autoScrollCheckBox;
        private System.Windows.Forms.RichTextBox hexTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

