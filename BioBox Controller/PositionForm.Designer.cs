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
            this.clearButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.applyCalibButton = new System.Windows.Forms.Button();
            this.input12 = new System.Windows.Forms.TextBox();
            this.input11 = new System.Windows.Forms.TextBox();
            this.input10 = new System.Windows.Forms.TextBox();
            this.input9 = new System.Windows.Forms.TextBox();
            this.input8 = new System.Windows.Forms.TextBox();
            this.input7 = new System.Windows.Forms.TextBox();
            this.input6 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dots1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.tabPage3.Size = new System.Drawing.Size(258, 258);
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
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.importButton);
            this.tabPage2.Controls.Add(this.exportButton);
            this.tabPage2.Controls.Add(this.applyCalibButton);
            this.tabPage2.Controls.Add(this.input12);
            this.tabPage2.Controls.Add(this.input11);
            this.tabPage2.Controls.Add(this.input10);
            this.tabPage2.Controls.Add(this.input9);
            this.tabPage2.Controls.Add(this.input8);
            this.tabPage2.Controls.Add(this.input7);
            this.tabPage2.Controls.Add(this.input6);
            this.tabPage2.Controls.Add(this.input5);
            this.tabPage2.Controls.Add(this.input4);
            this.tabPage2.Controls.Add(this.input3);
            this.tabPage2.Controls.Add(this.input2);
            this.tabPage2.Controls.Add(this.input1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(177, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(96, 204);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(96, 232);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // applyCalibButton
            // 
            this.applyCalibButton.Location = new System.Drawing.Point(177, 204);
            this.applyCalibButton.Name = "applyCalibButton";
            this.applyCalibButton.Size = new System.Drawing.Size(75, 23);
            this.applyCalibButton.TabIndex = 3;
            this.applyCalibButton.Text = "Apply";
            this.applyCalibButton.UseVisualStyleBackColor = true;
            this.applyCalibButton.Click += new System.EventHandler(this.applyCalibButton_Click);
            // 
            // input12
            // 
            this.input12.Location = new System.Drawing.Point(152, 175);
            this.input12.Name = "input12";
            this.input12.ReadOnly = true;
            this.input12.Size = new System.Drawing.Size(100, 23);
            this.input12.TabIndex = 2;
            // 
            // input11
            // 
            this.input11.Location = new System.Drawing.Point(152, 145);
            this.input11.Name = "input11";
            this.input11.ReadOnly = true;
            this.input11.Size = new System.Drawing.Size(100, 23);
            this.input11.TabIndex = 2;
            // 
            // input10
            // 
            this.input10.Location = new System.Drawing.Point(152, 116);
            this.input10.Name = "input10";
            this.input10.Size = new System.Drawing.Size(100, 23);
            this.input10.TabIndex = 2;
            // 
            // input9
            // 
            this.input9.Location = new System.Drawing.Point(152, 85);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(100, 23);
            this.input9.TabIndex = 2;
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(152, 55);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(100, 23);
            this.input8.TabIndex = 2;
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(152, 25);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(100, 23);
            this.input7.TabIndex = 2;
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(23, 175);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(100, 23);
            this.input6.TabIndex = 2;
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(23, 146);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(100, 23);
            this.input5.TabIndex = 2;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(23, 115);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 23);
            this.input4.TabIndex = 2;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(23, 86);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 23);
            this.input3.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(23, 55);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 23);
            this.input2.TabIndex = 2;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(23, 25);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 23);
            this.input1.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(125, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "12 -";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "11 -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "10 -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "9 -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "8 -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "7 -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "6 -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "5 -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "4 -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "3 -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "2 -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "1 -";
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
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dots1);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.title1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(177, 229);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 3;
            this.button16.Text = "Next Vial";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(96, 229);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Prev. Vial";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = ".................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = ".................................";
            // 
            // dots1
            // 
            this.dots1.AutoSize = true;
            this.dots1.Location = new System.Drawing.Point(65, 102);
            this.dots1.Name = "dots1";
            this.dots1.Size = new System.Drawing.Size(118, 15);
            this.dots1.TabIndex = 2;
            this.dots1.Text = ".....................................";
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(59, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "V12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(35, 73);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "V11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(23, 102);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "V10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(35, 131);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "V9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(59, 160);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "V8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(106, 169);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "V7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "V6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(179, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "V5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "V4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "V3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(152, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "V2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(105, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "V1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabControl.Size = new System.Drawing.Size(266, 286);
            this.tabControl.TabIndex = 1;
            // 
            // PositionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(288, 310);
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
        private Label label2;
        private Label label1;
        private Label dots1;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label title1;
        private TabControl tabControl;
        private TextBox input12;
        private TextBox input11;
        private TextBox input10;
        private TextBox input9;
        private TextBox input8;
        private TextBox input7;
        private TextBox input6;
        private TextBox input5;
        private TextBox input4;
        private TextBox input3;
        private TextBox input2;
        private TextBox input1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button applyCalibButton;
        private Button importButton;
        private Button exportButton;
        private Button clearButton;
    }
}