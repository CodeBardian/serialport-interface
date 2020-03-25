namespace SerialPort
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nFreq = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFlowControl = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.tDataBit = new System.Windows.Forms.TextBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.tBaudRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbChoice2 = new System.Windows.Forms.RadioButton();
            this.rbChoice1 = new System.Windows.Forms.RadioButton();
            this.lCommand = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.bCommand = new System.Windows.Forms.Button();
            this.cbCommands = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termsAndConditionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nFreq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nFreq
            // 
            this.nFreq.Location = new System.Drawing.Point(130, 44);
            this.nFreq.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nFreq.Name = "nFreq";
            this.nFreq.Size = new System.Drawing.Size(120, 20);
            this.nFreq.TabIndex = 0;
            this.nFreq.ThousandsSeparator = true;
            this.nFreq.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bReset);
            this.groupBox1.Controls.Add(this.bEnter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nFreq);
            this.groupBox1.Location = new System.Drawing.Point(34, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune in Frequency";
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(91, 90);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(59, 23);
            this.bReset.TabIndex = 3;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(156, 90);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(59, 23);
            this.bEnter.TabIndex = 2;
            this.bEnter.Text = "Submit";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.PortName = "COM10";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.bConnect);
            this.gbSettings.Controls.Add(this.cbPort);
            this.gbSettings.Controls.Add(this.label7);
            this.gbSettings.Location = new System.Drawing.Point(510, 41);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(203, 176);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(48, 108);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(110, 23);
            this.bConnect.TabIndex = 7;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.BConnect_Click);
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(101, 41);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(87, 21);
            this.cbPort.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Serial Port";
            // 
            // cbFlowControl
            // 
            this.cbFlowControl.FormattingEnabled = true;
            this.cbFlowControl.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cbFlowControl.Location = new System.Drawing.Point(455, 343);
            this.cbFlowControl.Name = "cbFlowControl";
            this.cbFlowControl.Size = new System.Drawing.Size(87, 21);
            this.cbFlowControl.TabIndex = 10;
            this.cbFlowControl.Visible = false;
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbStopBit.Location = new System.Drawing.Point(455, 288);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(87, 21);
            this.cbStopBit.TabIndex = 9;
            this.cbStopBit.Visible = false;
            // 
            // tDataBit
            // 
            this.tDataBit.Location = new System.Drawing.Point(455, 315);
            this.tDataBit.Name = "tDataBit";
            this.tDataBit.Size = new System.Drawing.Size(87, 20);
            this.tDataBit.TabIndex = 8;
            this.tDataBit.Text = "8";
            this.tDataBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tDataBit.Visible = false;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(455, 263);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(87, 21);
            this.cbParity.TabIndex = 8;
            this.cbParity.Visible = false;
            // 
            // tBaudRate
            // 
            this.tBaudRate.Location = new System.Drawing.Point(455, 238);
            this.tBaudRate.Name = "tBaudRate";
            this.tBaudRate.Size = new System.Drawing.Size(87, 20);
            this.tBaudRate.TabIndex = 7;
            this.tBaudRate.Text = "19200";
            this.tBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBaudRate.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Flow Control";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Bit";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stop Bit";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud Rate";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbChoice2);
            this.groupBox2.Controls.Add(this.rbChoice1);
            this.groupBox2.Controls.Add(this.lCommand);
            this.groupBox2.Controls.Add(this.tbCommand);
            this.groupBox2.Controls.Add(this.lResult);
            this.groupBox2.Controls.Add(this.bCommand);
            this.groupBox2.Controls.Add(this.cbCommands);
            this.groupBox2.Location = new System.Drawing.Point(34, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // rbChoice2
            // 
            this.rbChoice2.AutoSize = true;
            this.rbChoice2.Location = new System.Drawing.Point(156, 77);
            this.rbChoice2.Name = "rbChoice2";
            this.rbChoice2.Size = new System.Drawing.Size(31, 17);
            this.rbChoice2.TabIndex = 6;
            this.rbChoice2.TabStop = true;
            this.rbChoice2.Text = "2";
            this.rbChoice2.UseVisualStyleBackColor = true;
            this.rbChoice2.Visible = false;
            // 
            // rbChoice1
            // 
            this.rbChoice1.AutoSize = true;
            this.rbChoice1.Location = new System.Drawing.Point(156, 54);
            this.rbChoice1.Name = "rbChoice1";
            this.rbChoice1.Size = new System.Drawing.Size(31, 17);
            this.rbChoice1.TabIndex = 5;
            this.rbChoice1.TabStop = true;
            this.rbChoice1.Text = "1";
            this.rbChoice1.UseVisualStyleBackColor = true;
            this.rbChoice1.Visible = false;
            // 
            // lCommand
            // 
            this.lCommand.AutoSize = true;
            this.lCommand.Location = new System.Drawing.Point(84, 65);
            this.lCommand.Name = "lCommand";
            this.lCommand.Size = new System.Drawing.Size(54, 13);
            this.lCommand.TabIndex = 4;
            this.lCommand.Text = "Command";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(175, 62);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(33, 20);
            this.tbCommand.TabIndex = 3;
            this.tbCommand.Text = "15";
            this.tbCommand.Visible = false;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(71, 114);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 13);
            this.lResult.TabIndex = 2;
            // 
            // bCommand
            // 
            this.bCommand.Location = new System.Drawing.Point(224, 60);
            this.bCommand.Name = "bCommand";
            this.bCommand.Size = new System.Drawing.Size(65, 23);
            this.bCommand.TabIndex = 1;
            this.bCommand.Text = "Go!";
            this.bCommand.UseVisualStyleBackColor = true;
            this.bCommand.Click += new System.EventHandler(this.bCommand_Click);
            // 
            // cbCommands
            // 
            this.cbCommands.FormattingEnabled = true;
            this.cbCommands.Items.AddRange(new object[] {
            "11",
            "13",
            "14",
            "15",
            "17",
            "18",
            "19"});
            this.cbCommands.Location = new System.Drawing.Point(29, 62);
            this.cbCommands.Name = "cbCommands";
            this.cbCommands.Size = new System.Drawing.Size(49, 21);
            this.cbCommands.TabIndex = 0;
            this.cbCommands.SelectedIndexChanged += new System.EventHandler(this.cbCommands_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lStatus);
            this.groupBox3.Location = new System.Drawing.Point(34, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(26, 27);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(43, 13);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.termsAndConditionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.CommandsToolStripMenuItem_Click);
            // 
            // termsAndConditionsToolStripMenuItem
            // 
            this.termsAndConditionsToolStripMenuItem.Name = "termsAndConditionsToolStripMenuItem";
            this.termsAndConditionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.termsAndConditionsToolStripMenuItem.Text = "Terms and Conditions";
            this.termsAndConditionsToolStripMenuItem.Click += new System.EventHandler(this.TermsAndConditionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFlowControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbStopBit);
            this.Controls.Add(this.tDataBit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.tBaudRate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SerialPort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFreq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nFreq;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bReset;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbFlowControl;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.TextBox tDataBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.TextBox tBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCommand;
        private System.Windows.Forms.ComboBox cbCommands;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.RadioButton rbChoice2;
        private System.Windows.Forms.RadioButton rbChoice1;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termsAndConditionsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

