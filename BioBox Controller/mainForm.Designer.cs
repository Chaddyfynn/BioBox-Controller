namespace BioBox_Controller
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.directionText = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.Label();
            this.statusText2 = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.runningStatus = new System.Windows.Forms.Label();
            this.consoleText = new System.Windows.Forms.Label();
            this.controlInformationText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.runningStatusLabel = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.elapsedTitleText = new System.Windows.Forms.Label();
            this.countdownText = new System.Windows.Forms.Label();
            this.elapsedText = new System.Windows.Forms.Label();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.frequencyText = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.anticlockwiseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.applyGeneralButton = new System.Windows.Forms.Button();
            this.variableText = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fanTimeInput = new System.Windows.Forms.TextBox();
            this.activeFanTimeText = new System.Windows.Forms.Label();
            this.activeRunTimeText = new System.Windows.Forms.Label();
            this.activeDelayText = new System.Windows.Forms.Label();
            this.activePortText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portSubText = new System.Windows.Forms.Label();
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.runTimeInput = new System.Windows.Forms.TextBox();
            this.delayInput = new System.Windows.Forms.TextBox();
            this.delayText = new System.Windows.Forms.Label();
            this.fanTimeText = new System.Windows.Forms.Label();
            this.runTimeText = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.Label();
            this.coolingTitleText = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.fanTimer = new System.Windows.Forms.Timer(this.components);
            this.fanStatusLabel = new System.Windows.Forms.Label();
            this.fanStatusText = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(266, 407);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.directionText);
            this.tabPage1.Controls.Add(this.speedText);
            this.tabPage1.Controls.Add(this.statusText2);
            this.tabPage1.Controls.Add(this.connectionLabel);
            this.tabPage1.Controls.Add(this.runningStatus);
            this.tabPage1.Controls.Add(this.consoleText);
            this.tabPage1.Controls.Add(this.controlInformationText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.speedLabel);
            this.tabPage1.Controls.Add(this.directionLabel);
            this.tabPage1.Controls.Add(this.runningStatusLabel);
            this.tabPage1.Controls.Add(this.fanStatusLabel);
            this.tabPage1.Controls.Add(this.delayLabel);
            this.tabPage1.Controls.Add(this.elapsedTitleText);
            this.tabPage1.Controls.Add(this.fanStatusText);
            this.tabPage1.Controls.Add(this.countdownText);
            this.tabPage1.Controls.Add(this.elapsedText);
            this.tabPage1.Controls.Add(this.speedInput);
            this.tabPage1.Controls.Add(this.frequencyText);
            this.tabPage1.Controls.Add(this.stopButton);
            this.tabPage1.Controls.Add(this.stepButton);
            this.tabPage1.Controls.Add(this.clockwiseButton);
            this.tabPage1.Controls.Add(this.anticlockwiseButton);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.applyGeneralButton);
            this.tabPage1.Controls.Add(this.variableText);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // directionText
            // 
            this.directionText.AutoSize = true;
            this.directionText.Location = new System.Drawing.Point(122, 158);
            this.directionText.Name = "directionText";
            this.directionText.Size = new System.Drawing.Size(99, 15);
            this.directionText.TabIndex = 8;
            this.directionText.Text = "Hardware Default";
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Location = new System.Drawing.Point(122, 143);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(99, 15);
            this.speedText.TabIndex = 8;
            this.speedText.Text = "Hardware Default";
            // 
            // statusText2
            // 
            this.statusText2.AutoSize = true;
            this.statusText2.Location = new System.Drawing.Point(122, 178);
            this.statusText2.Name = "statusText2";
            this.statusText2.Size = new System.Drawing.Size(79, 15);
            this.statusText2.TabIndex = 6;
            this.statusText2.Text = "Disconnected";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(6, 178);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(115, 15);
            this.connectionLabel.TabIndex = 7;
            this.connectionLabel.Text = "Connection Status - ";
            // 
            // runningStatus
            // 
            this.runningStatus.AutoSize = true;
            this.runningStatus.Location = new System.Drawing.Point(122, 193);
            this.runningStatus.Name = "runningStatus";
            this.runningStatus.Size = new System.Drawing.Size(75, 15);
            this.runningStatus.TabIndex = 5;
            this.runningStatus.Text = "Not Running";
            // 
            // consoleText
            // 
            this.consoleText.AutoEllipsis = true;
            this.consoleText.AutoSize = true;
            this.consoleText.Location = new System.Drawing.Point(6, 121);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(57, 15);
            this.consoleText.TabIndex = 5;
            this.consoleText.Text = "Waiting...";
            // 
            // controlInformationText
            // 
            this.controlInformationText.AutoSize = true;
            this.controlInformationText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlInformationText.Location = new System.Drawing.Point(3, 86);
            this.controlInformationText.Name = "controlInformationText";
            this.controlInformationText.Size = new System.Drawing.Size(167, 15);
            this.controlInformationText.TabIndex = 5;
            this.controlInformationText.Text = "BioBox Control  Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Most Recent Console Message - ";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 143);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(66, 15);
            this.speedLabel.TabIndex = 5;
            this.speedLabel.Text = "Set Speed -";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(6, 158);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(66, 15);
            this.directionLabel.TabIndex = 5;
            this.directionLabel.Text = "Direction - ";
            // 
            // runningStatusLabel
            // 
            this.runningStatusLabel.AutoSize = true;
            this.runningStatusLabel.Location = new System.Drawing.Point(6, 193);
            this.runningStatusLabel.Name = "runningStatusLabel";
            this.runningStatusLabel.Size = new System.Drawing.Size(83, 15);
            this.runningStatusLabel.TabIndex = 5;
            this.runningStatusLabel.Text = "Motor Status -";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(6, 236);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(44, 15);
            this.delayLabel.TabIndex = 4;
            this.delayLabel.Text = "Delay -";
            // 
            // elapsedTitleText
            // 
            this.elapsedTitleText.AutoSize = true;
            this.elapsedTitleText.Location = new System.Drawing.Point(6, 251);
            this.elapsedTitleText.Name = "elapsedTitleText";
            this.elapsedTitleText.Size = new System.Drawing.Size(55, 15);
            this.elapsedTitleText.TabIndex = 4;
            this.elapsedTitleText.Text = "Elapsed -";
            // 
            // countdownText
            // 
            this.countdownText.AutoSize = true;
            this.countdownText.Location = new System.Drawing.Point(122, 236);
            this.countdownText.Name = "countdownText";
            this.countdownText.Size = new System.Drawing.Size(29, 15);
            this.countdownText.TabIndex = 4;
            this.countdownText.Text = "N/A";
            // 
            // elapsedText
            // 
            this.elapsedText.AutoSize = true;
            this.elapsedText.Location = new System.Drawing.Point(122, 251);
            this.elapsedText.Name = "elapsedText";
            this.elapsedText.Size = new System.Drawing.Size(29, 15);
            this.elapsedText.TabIndex = 4;
            this.elapsedText.Text = "N/A";
            // 
            // speedInput
            // 
            this.speedInput.Location = new System.Drawing.Point(87, 27);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(159, 23);
            this.speedInput.TabIndex = 3;
            // 
            // frequencyText
            // 
            this.frequencyText.AutoSize = true;
            this.frequencyText.Location = new System.Drawing.Point(6, 30);
            this.frequencyText.Name = "frequencyText";
            this.frequencyText.Size = new System.Drawing.Size(75, 15);
            this.frequencyText.TabIndex = 2;
            this.frequencyText.Text = "Speed (RPM)";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Location = new System.Drawing.Point(90, 318);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 52);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.BackColor = System.Drawing.Color.LightCoral;
            this.stepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stepButton.Location = new System.Drawing.Point(9, 318);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 1;
            this.stepButton.Text = "Fan";
            this.stepButton.UseVisualStyleBackColor = false;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clockwiseButton.Location = new System.Drawing.Point(171, 318);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.clockwiseButton.TabIndex = 1;
            this.clockwiseButton.Text = "Clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = true;
            this.clockwiseButton.Click += new System.EventHandler(this.clockwiseButton_Click);
            // 
            // anticlockwiseButton
            // 
            this.anticlockwiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anticlockwiseButton.Location = new System.Drawing.Point(171, 347);
            this.anticlockwiseButton.Name = "anticlockwiseButton";
            this.anticlockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.anticlockwiseButton.TabIndex = 1;
            this.anticlockwiseButton.Text = "Anti-Clockwise";
            this.anticlockwiseButton.UseVisualStyleBackColor = true;
            this.anticlockwiseButton.Click += new System.EventHandler(this.anticlockwiseButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(9, 347);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // applyGeneralButton
            // 
            this.applyGeneralButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyGeneralButton.Location = new System.Drawing.Point(171, 56);
            this.applyGeneralButton.Name = "applyGeneralButton";
            this.applyGeneralButton.Size = new System.Drawing.Size(75, 23);
            this.applyGeneralButton.TabIndex = 1;
            this.applyGeneralButton.Text = "Apply";
            this.applyGeneralButton.UseVisualStyleBackColor = true;
            this.applyGeneralButton.Click += new System.EventHandler(this.applyGeneralButton_Click);
            // 
            // variableText
            // 
            this.variableText.AutoSize = true;
            this.variableText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableText.Location = new System.Drawing.Point(3, 9);
            this.variableText.Name = "variableText";
            this.variableText.Size = new System.Drawing.Size(97, 15);
            this.variableText.TabIndex = 0;
            this.variableText.Text = "Motor Variables:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fanTimeInput);
            this.tabPage2.Controls.Add(this.activeFanTimeText);
            this.tabPage2.Controls.Add(this.activeRunTimeText);
            this.tabPage2.Controls.Add(this.activeDelayText);
            this.tabPage2.Controls.Add(this.activePortText);
            this.tabPage2.Controls.Add(this.statusText);
            this.tabPage2.Controls.Add(this.statusLabel);
            this.tabPage2.Controls.Add(this.portSubText);
            this.tabPage2.Controls.Add(this.portSelect);
            this.tabPage2.Controls.Add(this.reloadButton);
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.connectButton);
            this.tabPage2.Controls.Add(this.disconnectButton);
            this.tabPage2.Controls.Add(this.applySettingsButton);
            this.tabPage2.Controls.Add(this.runTimeInput);
            this.tabPage2.Controls.Add(this.delayInput);
            this.tabPage2.Controls.Add(this.delayText);
            this.tabPage2.Controls.Add(this.fanTimeText);
            this.tabPage2.Controls.Add(this.runTimeText);
            this.tabPage2.Controls.Add(this.portText);
            this.tabPage2.Controls.Add(this.coolingTitleText);
            this.tabPage2.Controls.Add(this.timerText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fanTimeInput
            // 
            this.fanTimeInput.Location = new System.Drawing.Point(99, 236);
            this.fanTimeInput.Name = "fanTimeInput";
            this.fanTimeInput.Size = new System.Drawing.Size(100, 23);
            this.fanTimeInput.TabIndex = 7;
            // 
            // activeFanTimeText
            // 
            this.activeFanTimeText.AutoSize = true;
            this.activeFanTimeText.Location = new System.Drawing.Point(205, 239);
            this.activeFanTimeText.Name = "activeFanTimeText";
            this.activeFanTimeText.Size = new System.Drawing.Size(21, 15);
            this.activeFanTimeText.TabIndex = 6;
            this.activeFanTimeText.Text = "5 s";
            // 
            // activeRunTimeText
            // 
            this.activeRunTimeText.AutoSize = true;
            this.activeRunTimeText.Location = new System.Drawing.Point(196, 54);
            this.activeRunTimeText.Name = "activeRunTimeText";
            this.activeRunTimeText.Size = new System.Drawing.Size(29, 15);
            this.activeRunTimeText.TabIndex = 6;
            this.activeRunTimeText.Text = "N/A";
            // 
            // activeDelayText
            // 
            this.activeDelayText.AutoSize = true;
            this.activeDelayText.Location = new System.Drawing.Point(196, 25);
            this.activeDelayText.Name = "activeDelayText";
            this.activeDelayText.Size = new System.Drawing.Size(21, 15);
            this.activeDelayText.TabIndex = 6;
            this.activeDelayText.Text = "0 s";
            // 
            // activePortText
            // 
            this.activePortText.AutoSize = true;
            this.activePortText.Location = new System.Drawing.Point(76, 148);
            this.activePortText.Name = "activePortText";
            this.activePortText.Size = new System.Drawing.Size(0, 15);
            this.activePortText.TabIndex = 5;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(76, 163);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(79, 15);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "Disconnected";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 163);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 15);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status - ";
            // 
            // portSubText
            // 
            this.portSubText.AutoSize = true;
            this.portSubText.Location = new System.Drawing.Point(6, 148);
            this.portSubText.Name = "portSubText";
            this.portSubText.Size = new System.Drawing.Size(73, 15);
            this.portSubText.TabIndex = 5;
            this.portSubText.Text = "Active Port -";
            // 
            // portSelect
            // 
            this.portSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(9, 122);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(121, 23);
            this.portSelect.TabIndex = 4;
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Location = new System.Drawing.Point(171, 122);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload Ports";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(171, 80);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Location = new System.Drawing.Point(9, 181);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectButton.Location = new System.Drawing.Point(90, 181);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applySettingsButton.Location = new System.Drawing.Point(171, 353);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 3;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // runTimeInput
            // 
            this.runTimeInput.Location = new System.Drawing.Point(90, 51);
            this.runTimeInput.Name = "runTimeInput";
            this.runTimeInput.Size = new System.Drawing.Size(100, 23);
            this.runTimeInput.TabIndex = 2;
            // 
            // delayInput
            // 
            this.delayInput.Location = new System.Drawing.Point(90, 22);
            this.delayInput.Name = "delayInput";
            this.delayInput.Size = new System.Drawing.Size(100, 23);
            this.delayInput.TabIndex = 2;
            // 
            // delayText
            // 
            this.delayText.AutoSize = true;
            this.delayText.Location = new System.Drawing.Point(6, 25);
            this.delayText.Name = "delayText";
            this.delayText.Size = new System.Drawing.Size(52, 15);
            this.delayText.TabIndex = 1;
            this.delayText.Text = "Delay (s)";
            // 
            // fanTimeText
            // 
            this.fanTimeText.AutoSize = true;
            this.fanTimeText.Location = new System.Drawing.Point(6, 239);
            this.fanTimeText.Name = "fanTimeText";
            this.fanTimeText.Size = new System.Drawing.Size(87, 15);
            this.fanTimeText.TabIndex = 1;
            this.fanTimeText.Text = "Fan Cooldown:";
            // 
            // runTimeText
            // 
            this.runTimeText.AutoSize = true;
            this.runTimeText.Location = new System.Drawing.Point(6, 54);
            this.runTimeText.Name = "runTimeText";
            this.runTimeText.Size = new System.Drawing.Size(73, 15);
            this.runTimeText.TabIndex = 1;
            this.runTimeText.Text = "Run Time (s)";
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portText.Location = new System.Drawing.Point(6, 104);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(34, 15);
            this.portText.TabIndex = 0;
            this.portText.Text = "Port:";
            // 
            // coolingTitleText
            // 
            this.coolingTitleText.AutoSize = true;
            this.coolingTitleText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolingTitleText.Location = new System.Drawing.Point(6, 216);
            this.coolingTitleText.Name = "coolingTitleText";
            this.coolingTitleText.Size = new System.Drawing.Size(95, 15);
            this.coolingTitleText.TabIndex = 0;
            this.coolingTitleText.Text = "Cooling System:";
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerText.Location = new System.Drawing.Point(6, 3);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(92, 15);
            this.timerText.TabIndex = 0;
            this.timerText.Text = "Timer Settings:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // delayTimer
            // 
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // runTimer
            // 
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // fanTimer
            // 
            this.fanTimer.Interval = 5000;
            this.fanTimer.Tick += new System.EventHandler(this.fanTimer_Tick);
            // 
            // fanStatusLabel
            // 
            this.fanStatusLabel.AutoSize = true;
            this.fanStatusLabel.Location = new System.Drawing.Point(6, 208);
            this.fanStatusLabel.Name = "fanStatusLabel";
            this.fanStatusLabel.Size = new System.Drawing.Size(69, 15);
            this.fanStatusLabel.TabIndex = 4;
            this.fanStatusLabel.Text = "Fan Status -";
            // 
            // fanStatusText
            // 
            this.fanStatusText.AutoSize = true;
            this.fanStatusText.Location = new System.Drawing.Point(122, 208);
            this.fanStatusText.Name = "fanStatusText";
            this.fanStatusText.Size = new System.Drawing.Size(75, 15);
            this.fanStatusText.TabIndex = 4;
            this.fanStatusText.Text = "Not Running";
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(288, 431);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "BioBox Stir-Bar";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label variableText;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Label frequencyText;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Button clockwiseButton;
        private System.Windows.Forms.Button anticlockwiseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button applyGeneralButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.TextBox runTimeInput;
        private System.Windows.Forms.TextBox delayInput;
        private System.Windows.Forms.Label delayText;
        private System.Windows.Forms.Label runTimeText;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label portText;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label activePortText;
        private System.Windows.Forms.Label portSubText;
        private System.Windows.Forms.Label activeRunTimeText;
        private System.Windows.Forms.Label activeDelayText;
        private System.Windows.Forms.Label elapsedTitleText;
        private System.Windows.Forms.Label elapsedText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label countdownText;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.Label runningStatusLabel;
        private System.Windows.Forms.Label runningStatus;
        private System.Windows.Forms.Label statusText2;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label directionText;
        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Label consoleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label controlInformationText;
        private System.Windows.Forms.Timer fanTimer;
        private System.Windows.Forms.Label coolingTitleText;
        private System.Windows.Forms.Label fanTimeText;
        private System.Windows.Forms.TextBox fanTimeInput;
        private System.Windows.Forms.Label activeFanTimeText;
        private System.Windows.Forms.Label fanStatusLabel;
        private System.Windows.Forms.Label fanStatusText;
    }
}

