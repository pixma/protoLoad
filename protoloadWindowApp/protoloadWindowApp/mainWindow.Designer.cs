namespace protoloadWindowApp
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.comportComboBox = new System.Windows.Forms.ComboBox();
            this.portButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ComPort_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLoad = new System.Windows.Forms.Label();
            this.loadFigure = new System.Windows.Forms.Label();
            this.dumpBox = new System.Windows.Forms.TextBox();
            this.buttonDumWIndowClear = new System.Windows.Forms.Button();
            this.comboBox_bitsps = new System.Windows.Forms.ComboBox();
            this.comboBox_databits = new System.Windows.Forms.ComboBox();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_stopBit = new System.Windows.Forms.ComboBox();
            this.comboBox_flowControl = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxVerbosMode = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.settingsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.textBox2);
            this.settingsGroup.Controls.Add(this.textBox1);
            this.settingsGroup.Controls.Add(this.comboBox_flowControl);
            this.settingsGroup.Controls.Add(this.comboBox_stopBit);
            this.settingsGroup.Controls.Add(this.comboBox_parity);
            this.settingsGroup.Controls.Add(this.comboBox_databits);
            this.settingsGroup.Controls.Add(this.comboBox_bitsps);
            this.settingsGroup.Controls.Add(this.portButton);
            this.settingsGroup.Controls.Add(this.comportComboBox);
            this.settingsGroup.Location = new System.Drawing.Point(13, 12);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(200, 528);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // comportComboBox
            // 
            this.comportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comportComboBox.FormattingEnabled = true;
            this.comportComboBox.Location = new System.Drawing.Point(7, 20);
            this.comportComboBox.Name = "comportComboBox";
            this.comportComboBox.Size = new System.Drawing.Size(187, 21);
            this.comportComboBox.TabIndex = 0;
            // 
            // portButton
            // 
            this.portButton.Location = new System.Drawing.Point(7, 47);
            this.portButton.Name = "portButton";
            this.portButton.Size = new System.Drawing.Size(187, 23);
            this.portButton.TabIndex = 1;
            this.portButton.Text = "Button";
            this.portButton.UseVisualStyleBackColor = true;
            this.portButton.Click += new System.EventHandler(this.portButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVerbosMode);
            this.groupBox1.Controls.Add(this.buttonDumWIndowClear);
            this.groupBox1.Controls.Add(this.dumpBox);
            this.groupBox1.Controls.Add(this.loadFigure);
            this.groupBox1.Controls.Add(this.labelLoad);
            this.groupBox1.Location = new System.Drawing.Point(220, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 527);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "protoloadPanel";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ComPort,
            this.toolStripStatusLabel_ComPort_Status,
            this.toolStripStatusLabel_Info});
            this.statusStrip.Location = new System.Drawing.Point(0, 543);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(904, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_ComPort
            // 
            this.toolStripStatusLabel_ComPort.Name = "toolStripStatusLabel_ComPort";
            this.toolStripStatusLabel_ComPort.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel_ComPort.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel_ComPort_Status
            // 
            this.toolStripStatusLabel_ComPort_Status.Name = "toolStripStatusLabel_ComPort_Status";
            this.toolStripStatusLabel_ComPort_Status.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel_ComPort_Status.Text = "toolStripStatusLabel1";
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(32, 26);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(31, 13);
            this.labelLoad.TabIndex = 0;
            this.labelLoad.Text = "Load";
            // 
            // loadFigure
            // 
            this.loadFigure.AutoSize = true;
            this.loadFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFigure.Location = new System.Drawing.Point(199, 26);
            this.loadFigure.Name = "loadFigure";
            this.loadFigure.Size = new System.Drawing.Size(19, 20);
            this.loadFigure.TabIndex = 1;
            this.loadFigure.Text = "0";
            // 
            // dumpBox
            // 
            this.dumpBox.Location = new System.Drawing.Point(35, 68);
            this.dumpBox.Multiline = true;
            this.dumpBox.Name = "dumpBox";
            this.dumpBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dumpBox.Size = new System.Drawing.Size(631, 418);
            this.dumpBox.TabIndex = 2;
            // 
            // buttonDumWIndowClear
            // 
            this.buttonDumWIndowClear.Location = new System.Drawing.Point(591, 498);
            this.buttonDumWIndowClear.Name = "buttonDumWIndowClear";
            this.buttonDumWIndowClear.Size = new System.Drawing.Size(75, 23);
            this.buttonDumWIndowClear.TabIndex = 3;
            this.buttonDumWIndowClear.Text = "Clear";
            this.buttonDumWIndowClear.UseVisualStyleBackColor = true;
            this.buttonDumWIndowClear.Click += new System.EventHandler(this.buttonDumWIndowClear_Click);
            // 
            // comboBox_bitsps
            // 
            this.comboBox_bitsps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bitsps.FormattingEnabled = true;
            this.comboBox_bitsps.Items.AddRange(new object[] {
            "Baud Rate",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "",
            ""});
            this.comboBox_bitsps.Location = new System.Drawing.Point(7, 179);
            this.comboBox_bitsps.Name = "comboBox_bitsps";
            this.comboBox_bitsps.Size = new System.Drawing.Size(187, 21);
            this.comboBox_bitsps.TabIndex = 2;
            // 
            // comboBox_databits
            // 
            this.comboBox_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_databits.FormattingEnabled = true;
            this.comboBox_databits.Items.AddRange(new object[] {
            "Data bits",
            "7",
            "8"});
            this.comboBox_databits.Location = new System.Drawing.Point(6, 206);
            this.comboBox_databits.Name = "comboBox_databits";
            this.comboBox_databits.Size = new System.Drawing.Size(188, 21);
            this.comboBox_databits.TabIndex = 3;
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Items.AddRange(new object[] {
            "Parity",
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.comboBox_parity.Location = new System.Drawing.Point(7, 233);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(188, 21);
            this.comboBox_parity.TabIndex = 4;
            // 
            // comboBox_stopBit
            // 
            this.comboBox_stopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stopBit.FormattingEnabled = true;
            this.comboBox_stopBit.Items.AddRange(new object[] {
            "Stop Bit",
            "1",
            "2"});
            this.comboBox_stopBit.Location = new System.Drawing.Point(6, 260);
            this.comboBox_stopBit.Name = "comboBox_stopBit";
            this.comboBox_stopBit.Size = new System.Drawing.Size(188, 21);
            this.comboBox_stopBit.TabIndex = 5;
            // 
            // comboBox_flowControl
            // 
            this.comboBox_flowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_flowControl.FormattingEnabled = true;
            this.comboBox_flowControl.Items.AddRange(new object[] {
            "Flow Control",
            "Xon / Xoff",
            "Hardware",
            "None"});
            this.comboBox_flowControl.Location = new System.Drawing.Point(6, 287);
            this.comboBox_flowControl.Name = "comboBox_flowControl";
            this.comboBox_flowControl.Size = new System.Drawing.Size(188, 21);
            this.comboBox_flowControl.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(7, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 105);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Default Settings (recommended)\r\n-----------------\r\nBaud Rate: 9600\r\nData Bits:   " +
    "8\r\nParity:         None\r\nStop Bits:    1\r\nFlow Control: None";
            // 
            // checkBoxVerbosMode
            // 
            this.checkBoxVerbosMode.AutoSize = true;
            this.checkBoxVerbosMode.Location = new System.Drawing.Point(35, 493);
            this.checkBoxVerbosMode.Name = "checkBoxVerbosMode";
            this.checkBoxVerbosMode.Size = new System.Drawing.Size(64, 17);
            this.checkBoxVerbosMode.TabIndex = 4;
            this.checkBoxVerbosMode.Text = "verbose";
            this.checkBoxVerbosMode.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(6, 127);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(188, 46);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Please set things before you connect to device.";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel_Info.Text = "toolStripStatusLabel1";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(904, 565);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.Button portButton;
        private System.Windows.Forms.ComboBox comportComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ComPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ComPort_Status;
        private System.Windows.Forms.Button buttonDumWIndowClear;
        private System.Windows.Forms.TextBox dumpBox;
        private System.Windows.Forms.Label loadFigure;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.ComboBox comboBox_flowControl;
        private System.Windows.Forms.ComboBox comboBox_stopBit;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_databits;
        private System.Windows.Forms.ComboBox comboBox_bitsps;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxVerbosMode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;


    }
}

