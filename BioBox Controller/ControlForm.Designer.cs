namespace BioBox_Controller
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.nextVialButton = new System.Windows.Forms.Button();
            this.prevVialButton = new System.Windows.Forms.Button();
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.anticlockwiseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.timesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.vialControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stirBarControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delayTitle = new System.Windows.Forms.Label();
            this.actionTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.motorPortActive = new System.Windows.Forms.Label();
            this.motorPortStatus = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portSubText = new System.Windows.Forms.Label();
            this.motorPortSelect = new System.Windows.Forms.ComboBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vialPortStatus = new System.Windows.Forms.Label();
            this.vialPortActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timesheetText = new System.Windows.Forms.Label();
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.experimentTimer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStat = new System.Windows.Forms.Label();
            this.currentVialStat = new System.Windows.Forms.Label();
            this.delayStat = new System.Windows.Forms.Label();
            this.runtimeStat = new System.Windows.Forms.Label();
            this.lastActionStat = new System.Windows.Forms.Label();
            this.nextActionStat = new System.Windows.Forms.Label();
            this.coolingStatusStat = new System.Windows.Forms.Label();
            this.vialStatusStat = new System.Windows.Forms.Label();
            this.beamStatusStat = new System.Windows.Forms.Label();
            this.motorStatusStat = new System.Windows.Forms.Label();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.vialPortSelect = new System.Windows.Forms.ComboBox();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextVialButton
            // 
            this.nextVialButton.BackColor = System.Drawing.Color.Transparent;
            this.nextVialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextVialButton.Location = new System.Drawing.Point(254, 274);
            this.nextVialButton.Name = "nextVialButton";
            this.nextVialButton.Size = new System.Drawing.Size(75, 23);
            this.nextVialButton.TabIndex = 5;
            this.nextVialButton.Text = "Next Vial";
            this.nextVialButton.UseVisualStyleBackColor = false;
            this.nextVialButton.Click += new System.EventHandler(this.nextVialButton_Click);
            // 
            // prevVialButton
            // 
            this.prevVialButton.BackColor = System.Drawing.Color.Transparent;
            this.prevVialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prevVialButton.Location = new System.Drawing.Point(254, 303);
            this.prevVialButton.Name = "prevVialButton";
            this.prevVialButton.Size = new System.Drawing.Size(75, 23);
            this.prevVialButton.TabIndex = 6;
            this.prevVialButton.Text = "Prev. Vial";
            this.prevVialButton.UseVisualStyleBackColor = false;
            this.prevVialButton.Click += new System.EventHandler(this.prevVialButton_Click);
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.BackColor = System.Drawing.Color.Transparent;
            this.clockwiseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clockwiseButton.Location = new System.Drawing.Point(335, 274);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.clockwiseButton.TabIndex = 7;
            this.clockwiseButton.Text = "Clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = false;
            this.clockwiseButton.Click += new System.EventHandler(this.clockwiseButton_Click);
            // 
            // anticlockwiseButton
            // 
            this.anticlockwiseButton.BackColor = System.Drawing.Color.Transparent;
            this.anticlockwiseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.anticlockwiseButton.Location = new System.Drawing.Point(335, 303);
            this.anticlockwiseButton.Name = "anticlockwiseButton";
            this.anticlockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.anticlockwiseButton.TabIndex = 8;
            this.anticlockwiseButton.Text = "Anti-Clock";
            this.anticlockwiseButton.UseVisualStyleBackColor = false;
            this.anticlockwiseButton.Click += new System.EventHandler(this.anticlockwiseButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Location = new System.Drawing.Point(92, 303);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Location = new System.Drawing.Point(173, 274);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 52);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // topMenu
            // 
            this.topMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.editButton,
            this.viewButton,
            this.helpButton});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(420, 25);
            this.topMenu.TabIndex = 11;
            this.topMenu.Text = "topMenu";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTimesheetToolStripMenuItem});
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(38, 22);
            this.fileButton.Text = "File";
            // 
            // openTimesheetToolStripMenuItem
            // 
            this.openTimesheetToolStripMenuItem.Name = "openTimesheetToolStripMenuItem";
            this.openTimesheetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openTimesheetToolStripMenuItem.Text = "Open Timesheet";
            this.openTimesheetToolStripMenuItem.Click += new System.EventHandler(this.openTimesheetToolStripMenuItem_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesheetToolStripMenuItem});
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 22);
            this.editButton.Text = "Edit";
            // 
            // timesheetToolStripMenuItem
            // 
            this.timesheetToolStripMenuItem.Name = "timesheetToolStripMenuItem";
            this.timesheetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timesheetToolStripMenuItem.Text = "Timesheet";
            this.timesheetToolStripMenuItem.Click += new System.EventHandler(this.timesheetToolStripMenuItem_Click);
            // 
            // viewButton
            // 
            this.viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vialControllerToolStripMenuItem,
            this.stirBarControllerToolStripMenuItem});
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(45, 22);
            this.viewButton.Text = "View";
            // 
            // vialControllerToolStripMenuItem
            // 
            this.vialControllerToolStripMenuItem.Name = "vialControllerToolStripMenuItem";
            this.vialControllerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vialControllerToolStripMenuItem.Text = "Vial Controller";
            this.vialControllerToolStripMenuItem.Click += new System.EventHandler(this.vialControllerToolStripMenuItem_Click);
            // 
            // stirBarControllerToolStripMenuItem
            // 
            this.stirBarControllerToolStripMenuItem.Name = "stirBarControllerToolStripMenuItem";
            this.stirBarControllerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stirBarControllerToolStripMenuItem.Text = "Stir Bar Controller";
            this.stirBarControllerToolStripMenuItem.Click += new System.EventHandler(this.stirBarControllerToolStripMenuItem_Click);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDocumentationToolStripMenuItem,
            this.viewSourceToolStripMenuItem});
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 22);
            this.helpButton.Text = "Help";
            // 
            // viewDocumentationToolStripMenuItem
            // 
            this.viewDocumentationToolStripMenuItem.Name = "viewDocumentationToolStripMenuItem";
            this.viewDocumentationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewDocumentationToolStripMenuItem.Text = "View Documentation";
            this.viewDocumentationToolStripMenuItem.Click += new System.EventHandler(this.viewDocumentationToolStripMenuItem_Click);
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            this.viewSourceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewSourceToolStripMenuItem.Text = "View Source";
            // 
            // delayTitle
            // 
            this.delayTitle.AutoSize = true;
            this.delayTitle.Location = new System.Drawing.Point(9, 191);
            this.delayTitle.Name = "delayTitle";
            this.delayTitle.Size = new System.Drawing.Size(72, 15);
            this.delayTitle.TabIndex = 12;
            this.delayTitle.Text = "Next Event -";
            // 
            // actionTitle
            // 
            this.actionTitle.AutoSize = true;
            this.actionTitle.Location = new System.Drawing.Point(9, 226);
            this.actionTitle.Name = "actionTitle";
            this.actionTitle.Size = new System.Drawing.Size(74, 15);
            this.actionTitle.TabIndex = 12;
            this.actionTitle.Text = "Last Action -";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(11, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(11, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // motorPortActive
            // 
            this.motorPortActive.AutoSize = true;
            this.motorPortActive.Location = new System.Drawing.Point(78, 66);
            this.motorPortActive.Name = "motorPortActive";
            this.motorPortActive.Size = new System.Drawing.Size(46, 15);
            this.motorPortActive.TabIndex = 19;
            this.motorPortActive.Text = "Not Set";
            // 
            // motorPortStatus
            // 
            this.motorPortStatus.AutoSize = true;
            this.motorPortStatus.Location = new System.Drawing.Point(78, 81);
            this.motorPortStatus.Name = "motorPortStatus";
            this.motorPortStatus.Size = new System.Drawing.Size(79, 15);
            this.motorPortStatus.TabIndex = 20;
            this.motorPortStatus.Text = "Disconnected";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 81);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 15);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Status - ";
            // 
            // portSubText
            // 
            this.portSubText.AutoSize = true;
            this.portSubText.Location = new System.Drawing.Point(8, 66);
            this.portSubText.Name = "portSubText";
            this.portSubText.Size = new System.Drawing.Size(73, 15);
            this.portSubText.TabIndex = 22;
            this.portSubText.Text = "Active Port -";
            // 
            // motorPortSelect
            // 
            this.motorPortSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motorPortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motorPortSelect.FormattingEnabled = true;
            this.motorPortSelect.Location = new System.Drawing.Point(11, 40);
            this.motorPortSelect.Name = "motorPortSelect";
            this.motorPortSelect.Size = new System.Drawing.Size(121, 23);
            this.motorPortSelect.TabIndex = 18;
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Location = new System.Drawing.Point(173, 99);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 15;
            this.reloadButton.Text = "Reload Ports";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portText.Location = new System.Drawing.Point(8, 22);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(120, 15);
            this.portText.TabIndex = 14;
            this.portText.Text = "Coil Microcontroller:";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectButton.Location = new System.Drawing.Point(92, 99);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 17;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Location = new System.Drawing.Point(11, 99);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 16;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Active Port -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Status - ";
            // 
            // vialPortStatus
            // 
            this.vialPortStatus.AutoSize = true;
            this.vialPortStatus.Location = new System.Drawing.Point(321, 81);
            this.vialPortStatus.Name = "vialPortStatus";
            this.vialPortStatus.Size = new System.Drawing.Size(79, 15);
            this.vialPortStatus.TabIndex = 20;
            this.vialPortStatus.Text = "Disconnected";
            // 
            // vialPortActive
            // 
            this.vialPortActive.AutoSize = true;
            this.vialPortActive.Location = new System.Drawing.Point(321, 66);
            this.vialPortActive.Name = "vialPortActive";
            this.vialPortActive.Size = new System.Drawing.Size(46, 15);
            this.vialPortActive.TabIndex = 19;
            this.vialPortActive.Text = "Not Set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Vial Microcontroller:";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Khaki;
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pauseButton.Location = new System.Drawing.Point(92, 274);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Timesheet -";
            // 
            // timesheetText
            // 
            this.timesheetText.AutoEllipsis = true;
            this.timesheetText.AutoSize = true;
            this.timesheetText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesheetText.Location = new System.Drawing.Point(110, 256);
            this.timesheetText.Name = "timesheetText";
            this.timesheetText.Size = new System.Drawing.Size(83, 15);
            this.timesheetText.TabIndex = 24;
            this.timesheetText.Text = "None Selected";
            // 
            // runTimer
            // 
            this.runTimer.Interval = 1000;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Runtime - ";
            // 
            // experimentTimer
            // 
            this.experimentTimer.Tick += new System.EventHandler(this.experimentTimer_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Statistics:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Status -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Current Vial -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Current  Action -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Motor Status -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Cooling Status -";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Vial Status -";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(202, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Beam Status -";
            // 
            // statusStat
            // 
            this.statusStat.AutoSize = true;
            this.statusStat.Location = new System.Drawing.Point(110, 141);
            this.statusStat.Name = "statusStat";
            this.statusStat.Size = new System.Drawing.Size(44, 15);
            this.statusStat.TabIndex = 28;
            this.statusStat.Text = "No File";
            // 
            // currentVialStat
            // 
            this.currentVialStat.AutoSize = true;
            this.currentVialStat.Location = new System.Drawing.Point(110, 171);
            this.currentVialStat.Name = "currentVialStat";
            this.currentVialStat.Size = new System.Drawing.Size(29, 15);
            this.currentVialStat.TabIndex = 28;
            this.currentVialStat.Text = "N/A";
            // 
            // delayStat
            // 
            this.delayStat.AutoSize = true;
            this.delayStat.Location = new System.Drawing.Point(110, 191);
            this.delayStat.Name = "delayStat";
            this.delayStat.Size = new System.Drawing.Size(29, 15);
            this.delayStat.TabIndex = 28;
            this.delayStat.Text = "N/A";
            // 
            // runtimeStat
            // 
            this.runtimeStat.AutoSize = true;
            this.runtimeStat.Location = new System.Drawing.Point(110, 206);
            this.runtimeStat.Name = "runtimeStat";
            this.runtimeStat.Size = new System.Drawing.Size(29, 15);
            this.runtimeStat.TabIndex = 28;
            this.runtimeStat.Text = "N/A";
            // 
            // lastActionStat
            // 
            this.lastActionStat.AutoSize = true;
            this.lastActionStat.Location = new System.Drawing.Point(110, 226);
            this.lastActionStat.Name = "lastActionStat";
            this.lastActionStat.Size = new System.Drawing.Size(44, 15);
            this.lastActionStat.TabIndex = 28;
            this.lastActionStat.Text = "No File";
            // 
            // nextActionStat
            // 
            this.nextActionStat.AutoSize = true;
            this.nextActionStat.Location = new System.Drawing.Point(110, 241);
            this.nextActionStat.Name = "nextActionStat";
            this.nextActionStat.Size = new System.Drawing.Size(44, 15);
            this.nextActionStat.TabIndex = 28;
            this.nextActionStat.Text = "No File";
            // 
            // coolingStatusStat
            // 
            this.coolingStatusStat.AutoSize = true;
            this.coolingStatusStat.Location = new System.Drawing.Point(110, 156);
            this.coolingStatusStat.Name = "coolingStatusStat";
            this.coolingStatusStat.Size = new System.Drawing.Size(29, 15);
            this.coolingStatusStat.TabIndex = 28;
            this.coolingStatusStat.Text = "N/A";
            // 
            // vialStatusStat
            // 
            this.vialStatusStat.AutoSize = true;
            this.vialStatusStat.Location = new System.Drawing.Point(288, 141);
            this.vialStatusStat.Name = "vialStatusStat";
            this.vialStatusStat.Size = new System.Drawing.Size(29, 15);
            this.vialStatusStat.TabIndex = 28;
            this.vialStatusStat.Text = "N/A";
            // 
            // beamStatusStat
            // 
            this.beamStatusStat.AutoSize = true;
            this.beamStatusStat.Location = new System.Drawing.Point(288, 156);
            this.beamStatusStat.Name = "beamStatusStat";
            this.beamStatusStat.Size = new System.Drawing.Size(29, 15);
            this.beamStatusStat.TabIndex = 28;
            this.beamStatusStat.Text = "N/A";
            // 
            // motorStatusStat
            // 
            this.motorStatusStat.AutoSize = true;
            this.motorStatusStat.Location = new System.Drawing.Point(288, 171);
            this.motorStatusStat.Name = "motorStatusStat";
            this.motorStatusStat.Size = new System.Drawing.Size(29, 15);
            this.motorStatusStat.TabIndex = 28;
            this.motorStatusStat.Text = "N/A";
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 1000;
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // vialPortSelect
            // 
            this.vialPortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vialPortSelect.FormattingEnabled = true;
            this.vialPortSelect.IntegralHeight = false;
            this.vialPortSelect.Location = new System.Drawing.Point(254, 40);
            this.vialPortSelect.Name = "vialPortSelect";
            this.vialPortSelect.Size = new System.Drawing.Size(121, 23);
            this.vialPortSelect.TabIndex = 29;
            // 
            // ControlForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.vialPortSelect);
            this.Controls.Add(this.beamStatusStat);
            this.Controls.Add(this.vialStatusStat);
            this.Controls.Add(this.motorStatusStat);
            this.Controls.Add(this.coolingStatusStat);
            this.Controls.Add(this.nextActionStat);
            this.Controls.Add(this.lastActionStat);
            this.Controls.Add(this.runtimeStat);
            this.Controls.Add(this.delayStat);
            this.Controls.Add(this.currentVialStat);
            this.Controls.Add(this.statusStat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.timesheetText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vialPortActive);
            this.Controls.Add(this.motorPortActive);
            this.Controls.Add(this.vialPortStatus);
            this.Controls.Add(this.motorPortStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portSubText);
            this.Controls.Add(this.motorPortSelect);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delayTitle);
            this.Controls.Add(this.actionTitle);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.nextVialButton);
            this.Controls.Add(this.prevVialButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clockwiseButton);
            this.Controls.Add(this.anticlockwiseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BioBox Control Panel";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextVialButton;
        private System.Windows.Forms.Button prevVialButton;
        private System.Windows.Forms.Button clockwiseButton;
        private System.Windows.Forms.Button anticlockwiseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStrip topMenu;
        private System.Windows.Forms.Label delayTitle;
        private System.Windows.Forms.Label actionTitle;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripDropDownButton editButton;
        private System.Windows.Forms.ToolStripMenuItem timesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton helpButton;
        private System.Windows.Forms.ToolStripMenuItem viewDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton viewButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label motorPortActive;
        private System.Windows.Forms.Label motorPortStatus;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label portSubText;
        private System.Windows.Forms.ComboBox motorPortSelect;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label portText;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vialPortStatus;
        private System.Windows.Forms.Label vialPortActive;
        private System.Windows.Forms.ToolStripMenuItem vialControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stirBarControllerToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem openTimesheetToolStripMenuItem;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timesheetText;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer experimentTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label statusStat;
        private System.Windows.Forms.Label currentVialStat;
        private System.Windows.Forms.Label delayStat;
        private System.Windows.Forms.Label runtimeStat;
        private System.Windows.Forms.Label lastActionStat;
        private System.Windows.Forms.Label nextActionStat;
        private System.Windows.Forms.Label coolingStatusStat;
        private System.Windows.Forms.Label vialStatusStat;
        private System.Windows.Forms.Label beamStatusStat;
        private System.Windows.Forms.Label motorStatusStat;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.ComboBox vialPortSelect;
    }
}