using System.Windows.Forms;

namespace BioBox_Controller
{
    partial class PositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.activePortText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portSubText = new System.Windows.Forms.Label();
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.totalNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalVialsInput = new System.Windows.Forms.TextBox();
            this.totalNumVialsButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.vialDutyInput = new System.Windows.Forms.TextBox();
            this.vialNumInput = new System.Windows.Forms.TextBox();
            this.vialDutyBox = new System.Windows.Forms.RichTextBox();
            this.vialNumBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.applyCalibButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.currentVelocityText = new System.Windows.Forms.Label();
            this.currentAngleText = new System.Windows.Forms.Label();
            this.currentVialText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.velocityButton = new System.Windows.Forms.Button();
            this.a2bButton = new System.Windows.Forms.Button();
            this.angleButton = new System.Windows.Forms.Button();
            this.bBox = new System.Windows.Forms.TextBox();
            this.velocityBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.dutyCycleBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dutyCycleButton = new System.Windows.Forms.Button();
            this.goToButton = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label7 = new System.Windows.Forms.Label();
            this.currentOffsetText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.vialOffsetBox = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.activePortText);
            this.tabPage3.Controls.Add(this.statusText);
            this.tabPage3.Controls.Add(this.statusLabel);
            this.tabPage3.Controls.Add(this.portSubText);
            this.tabPage3.Controls.Add(this.portSelect);
            this.tabPage3.Controls.Add(this.reloadButton);
            this.tabPage3.Controls.Add(this.connectButton);
            this.tabPage3.Controls.Add(this.disconnectButton);
            this.tabPage3.Controls.Add(this.portText);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(258, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // activePortText
            // 
            this.activePortText.AutoSize = true;
            this.activePortText.Location = new System.Drawing.Point(73, 50);
            this.activePortText.Name = "activePortText";
            this.activePortText.Size = new System.Drawing.Size(46, 15);
            this.activePortText.TabIndex = 11;
            this.activePortText.Text = "Not Set";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(73, 65);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(79, 15);
            this.statusText.TabIndex = 11;
            this.statusText.Text = "Disconnected";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 65);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 15);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status - ";
            // 
            // portSubText
            // 
            this.portSubText.AutoSize = true;
            this.portSubText.Location = new System.Drawing.Point(3, 50);
            this.portSubText.Name = "portSubText";
            this.portSubText.Size = new System.Drawing.Size(73, 15);
            this.portSubText.TabIndex = 13;
            this.portSubText.Text = "Active Port -";
            // 
            // portSelect
            // 
            this.portSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(6, 24);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(121, 23);
            this.portSelect.TabIndex = 10;
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Location = new System.Drawing.Point(168, 24);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 7;
            this.reloadButton.Text = "Reload Ports";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Location = new System.Drawing.Point(6, 83);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectButton.Location = new System.Drawing.Point(87, 83);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portText.Location = new System.Drawing.Point(3, 6);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(34, 15);
            this.portText.TabIndex = 6;
            this.portText.Text = "Port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalNum);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.totalVialsInput);
            this.tabPage2.Controls.Add(this.totalNumVialsButton);
            this.tabPage2.Controls.Add(this.undoButton);
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.vialDutyInput);
            this.tabPage2.Controls.Add(this.vialNumInput);
            this.tabPage2.Controls.Add(this.vialDutyBox);
            this.tabPage2.Controls.Add(this.vialNumBox);
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.importButton);
            this.tabPage2.Controls.Add(this.exportButton);
            this.tabPage2.Controls.Add(this.applyCalibButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // totalNum
            // 
            this.totalNum.AutoSize = true;
            this.totalNum.Location = new System.Drawing.Point(41, 178);
            this.totalNum.Name = "totalNum";
            this.totalNum.Size = new System.Drawing.Size(46, 15);
            this.totalNum.TabIndex = 12;
            this.totalNum.Text = "Not Set";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Num";
            // 
            // totalVialsInput
            // 
            this.totalVialsInput.Location = new System.Drawing.Point(51, 151);
            this.totalVialsInput.Name = "totalVialsInput";
            this.totalVialsInput.Size = new System.Drawing.Size(39, 23);
            this.totalVialsInput.TabIndex = 11;
            // 
            // totalNumVialsButton
            // 
            this.totalNumVialsButton.Location = new System.Drawing.Point(6, 151);
            this.totalNumVialsButton.Name = "totalNumVialsButton";
            this.totalNumVialsButton.Size = new System.Drawing.Size(39, 23);
            this.totalNumVialsButton.TabIndex = 10;
            this.totalNumVialsButton.Text = "Set Total";
            this.totalNumVialsButton.UseVisualStyleBackColor = true;
            this.totalNumVialsButton.Click += new System.EventHandler(this.totalNumVialsButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(6, 108);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(84, 23);
            this.undoButton.TabIndex = 9;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add/Replace";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // vialDutyInput
            // 
            this.vialDutyInput.Location = new System.Drawing.Point(44, 50);
            this.vialDutyInput.Name = "vialDutyInput";
            this.vialDutyInput.Size = new System.Drawing.Size(46, 23);
            this.vialDutyInput.TabIndex = 8;
            // 
            // vialNumInput
            // 
            this.vialNumInput.Location = new System.Drawing.Point(41, 22);
            this.vialNumInput.Name = "vialNumInput";
            this.vialNumInput.Size = new System.Drawing.Size(49, 23);
            this.vialNumInput.TabIndex = 8;
            // 
            // vialDutyBox
            // 
            this.vialDutyBox.Location = new System.Drawing.Point(150, 21);
            this.vialDutyBox.Name = "vialDutyBox";
            this.vialDutyBox.ReadOnly = true;
            this.vialDutyBox.Size = new System.Drawing.Size(102, 465);
            this.vialDutyBox.TabIndex = 7;
            this.vialDutyBox.Text = "";
            // 
            // vialNumBox
            // 
            this.vialNumBox.Location = new System.Drawing.Point(96, 21);
            this.vialNumBox.Name = "vialNumBox";
            this.vialNumBox.ReadOnly = true;
            this.vialNumBox.Size = new System.Drawing.Size(48, 465);
            this.vialNumBox.TabIndex = 7;
            this.vialNumBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 431);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(9, 373);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(84, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(9, 402);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(84, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // applyCalibButton
            // 
            this.applyCalibButton.Location = new System.Drawing.Point(9, 460);
            this.applyCalibButton.Name = "applyCalibButton";
            this.applyCalibButton.Size = new System.Drawing.Size(84, 23);
            this.applyCalibButton.TabIndex = 3;
            this.applyCalibButton.Text = "Apply";
            this.applyCalibButton.UseVisualStyleBackColor = true;
            this.applyCalibButton.Click += new System.EventHandler(this.applyCalibButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vial Number Duty Cycle:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.homeButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.currentOffsetText);
            this.tabPage1.Controls.Add(this.currentVelocityText);
            this.tabPage1.Controls.Add(this.currentAngleText);
            this.tabPage1.Controls.Add(this.currentVialText);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.velocityButton);
            this.tabPage1.Controls.Add(this.a2bButton);
            this.tabPage1.Controls.Add(this.angleButton);
            this.tabPage1.Controls.Add(this.bBox);
            this.tabPage1.Controls.Add(this.velocityBox);
            this.tabPage1.Controls.Add(this.aBox);
            this.tabPage1.Controls.Add(this.angleBox);
            this.tabPage1.Controls.Add(this.vialOffsetBox);
            this.tabPage1.Controls.Add(this.dutyCycleBox);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dutyCycleButton);
            this.tabPage1.Controls.Add(this.goToButton);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.title1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // currentVelocityText
            // 
            this.currentVelocityText.AutoSize = true;
            this.currentVelocityText.Location = new System.Drawing.Point(112, 269);
            this.currentVelocityText.Name = "currentVelocityText";
            this.currentVelocityText.Size = new System.Drawing.Size(29, 15);
            this.currentVelocityText.TabIndex = 9;
            this.currentVelocityText.Text = "N/A";
            // 
            // currentAngleText
            // 
            this.currentAngleText.AutoSize = true;
            this.currentAngleText.Location = new System.Drawing.Point(112, 254);
            this.currentAngleText.Name = "currentAngleText";
            this.currentAngleText.Size = new System.Drawing.Size(29, 15);
            this.currentAngleText.TabIndex = 9;
            this.currentAngleText.Text = "N/A";
            // 
            // currentVialText
            // 
            this.currentVialText.AutoSize = true;
            this.currentVialText.Location = new System.Drawing.Point(112, 239);
            this.currentVialText.Name = "currentVialText";
            this.currentVialText.Size = new System.Drawing.Size(29, 15);
            this.currentVialText.TabIndex = 9;
            this.currentVialText.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Velocity - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Current Angle - ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Set Vial -";
            // 
            // velocityButton
            // 
            this.velocityButton.Location = new System.Drawing.Point(6, 198);
            this.velocityButton.Name = "velocityButton";
            this.velocityButton.Size = new System.Drawing.Size(75, 23);
            this.velocityButton.TabIndex = 7;
            this.velocityButton.Text = "Velocity";
            this.velocityButton.UseVisualStyleBackColor = true;
            this.velocityButton.Click += new System.EventHandler(this.velocityButton_Click);
            // 
            // a2bButton
            // 
            this.a2bButton.Location = new System.Drawing.Point(6, 173);
            this.a2bButton.Name = "a2bButton";
            this.a2bButton.Size = new System.Drawing.Size(75, 23);
            this.a2bButton.TabIndex = 7;
            this.a2bButton.Text = "A to B";
            this.a2bButton.UseVisualStyleBackColor = true;
            this.a2bButton.Click += new System.EventHandler(this.a2bButton_Click);
            // 
            // angleButton
            // 
            this.angleButton.Location = new System.Drawing.Point(6, 93);
            this.angleButton.Name = "angleButton";
            this.angleButton.Size = new System.Drawing.Size(75, 23);
            this.angleButton.TabIndex = 6;
            this.angleButton.Text = "Angle";
            this.angleButton.UseVisualStyleBackColor = true;
            this.angleButton.Click += new System.EventHandler(this.angleButton_Click);
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(168, 173);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(75, 23);
            this.bBox.TabIndex = 5;
            // 
            // velocityBox
            // 
            this.velocityBox.Location = new System.Drawing.Point(87, 198);
            this.velocityBox.Name = "velocityBox";
            this.velocityBox.Size = new System.Drawing.Size(75, 23);
            this.velocityBox.TabIndex = 5;
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(87, 173);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(75, 23);
            this.aBox.TabIndex = 5;
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(87, 93);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(75, 23);
            this.angleBox.TabIndex = 5;
            // 
            // dutyCycleBox
            // 
            this.dutyCycleBox.Location = new System.Drawing.Point(87, 69);
            this.dutyCycleBox.Name = "dutyCycleBox";
            this.dutyCycleBox.Size = new System.Drawing.Size(75, 23);
            this.dutyCycleBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.TabIndex = 5;
            // 
            // dutyCycleButton
            // 
            this.dutyCycleButton.Location = new System.Drawing.Point(6, 69);
            this.dutyCycleButton.Name = "dutyCycleButton";
            this.dutyCycleButton.Size = new System.Drawing.Size(75, 23);
            this.dutyCycleButton.TabIndex = 4;
            this.dutyCycleButton.Text = "Offset";
            this.dutyCycleButton.UseVisualStyleBackColor = true;
            this.dutyCycleButton.Click += new System.EventHandler(this.dutyCycleButton_Click);
            // 
            // goToButton
            // 
            this.goToButton.Location = new System.Drawing.Point(6, 21);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(75, 23);
            this.goToButton.TabIndex = 4;
            this.goToButton.Text = "Vial No.";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 122);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 3;
            this.button16.Text = "Next Vial";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(87, 122);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Prev. Vial";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(3, 3);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(85, 15);
            this.title1.TabIndex = 0;
            this.title1.Text = "Vial Selection:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(11, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(266, 520);
            this.tabControl.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Set Offset - ";
            // 
            // currentOffsetText
            // 
            this.currentOffsetText.AutoSize = true;
            this.currentOffsetText.Location = new System.Drawing.Point(111, 284);
            this.currentOffsetText.Name = "currentOffsetText";
            this.currentOffsetText.Size = new System.Drawing.Size(29, 15);
            this.currentOffsetText.TabIndex = 9;
            this.currentOffsetText.Text = "N/A";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Vial Offset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(168, 122);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // vialOffsetBox
            // 
            this.vialOffsetBox.Location = new System.Drawing.Point(87, 45);
            this.vialOffsetBox.Name = "vialOffsetBox";
            this.vialOffsetBox.Size = new System.Drawing.Size(75, 23);
            this.vialOffsetBox.TabIndex = 5;
            // 
            // PositionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(288, 544);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BioBox Vial";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.FormClosing += PositionForm_FormClosing1;

        }

        private void PositionForm_FormClosing1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        #endregion

        private TabPage tabPage3;
        private Label activePortText;
        private Label statusText;
        private Label statusLabel;
        private Label portSubText;
        private ComboBox portSelect;
        private Button reloadButton;
        private Button connectButton;
        private Button disconnectButton;
        private Label portText;
        private TabPage tabPage2;
        private Label label4;
        private TabPage tabPage1;
        private Button button16;
        private Button button13;
        private Label title1;
        private TabControl tabControl;
        private Button applyCalibButton;
        private Button importButton;
        private Button exportButton;
        private Button clearButton;
        private TextBox vialDutyInput;
        private TextBox vialNumInput;
        private RichTextBox vialDutyBox;
        private RichTextBox vialNumBox;
        private TextBox textBox1;
        private Button goToButton;
        private Button undoButton;
        private Button addButton;
        private TextBox totalVialsInput;
        private Button totalNumVialsButton;
        private Label label2;
        private Label label1;
        private Label totalNum;
        private Label label5;
        private TextBox dutyCycleBox;
        private Button dutyCycleButton;
        private Button velocityButton;
        private Button a2bButton;
        private Button angleButton;
        private TextBox bBox;
        private TextBox aBox;
        private TextBox angleBox;
        private Label currentAngleText;
        private Label currentVialText;
        private Label label8;
        private Label label6;
        private TextBox velocityBox;
        private Label currentVelocityText;
        private Label label3;
        private Label currentOffsetText;
        private Label label7;
        private Button homeButton;
        private Button button1;
        private TextBox vialOffsetBox;
    }
}