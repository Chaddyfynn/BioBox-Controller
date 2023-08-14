using System.Windows.Forms;

namespace BioBox_Controller
{
    partial class TimesheetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesheetEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.displayPromptInput = new System.Windows.Forms.TextBox();
            this.insertDelayInput = new System.Windows.Forms.TextBox();
            this.goToVialInput = new System.Windows.Forms.TextBox();
            this.rpmInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prevVialButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadCalibButton = new System.Windows.Forms.Button();
            this.waitForUserButton = new System.Windows.Forms.Button();
            this.clsoeCupButton = new System.Windows.Forms.Button();
            this.displayPromptButton = new System.Windows.Forms.Button();
            this.insertDelayButton = new System.Windows.Forms.Button();
            this.nextVialButton = new System.Windows.Forms.Button();
            this.openCupButton = new System.Windows.Forms.Button();
            this.stopFanButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.undoTactileButton = new System.Windows.Forms.Button();
            this.startFanButton = new System.Windows.Forms.Button();
            this.functionTitle1 = new System.Windows.Forms.Label();
            this.goToVialButton = new System.Windows.Forms.Button();
            this.setRpmButton = new System.Windows.Forms.Button();
            this.anticlockwiseButton = new System.Windows.Forms.Button();
            this.stopStirringButton = new System.Windows.Forms.Button();
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.startStirringButton = new System.Windows.Forms.Button();
            this.actionTextBox = new System.Windows.Forms.RichTextBox();
            this.timeTextBox = new System.Windows.Forms.RichTextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.editButton,
            this.helpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileButton.Image = ((System.Drawing.Image)(resources.GetObject("fileButton.Image")));
            this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(38, 22);
            this.fileButton.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openToolStripMenuItem.Text = "Open Timesheet";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 22);
            this.editButton.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
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
            this.viewSourceToolStripMenuItem.Click += new System.EventHandler(this.viewSourceToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.displayPromptInput);
            this.splitContainer1.Panel1.Controls.Add(this.insertDelayInput);
            this.splitContainer1.Panel1.Controls.Add(this.goToVialInput);
            this.splitContainer1.Panel1.Controls.Add(this.rpmInput);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.prevVialButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.loadCalibButton);
            this.splitContainer1.Panel1.Controls.Add(this.waitForUserButton);
            this.splitContainer1.Panel1.Controls.Add(this.clsoeCupButton);
            this.splitContainer1.Panel1.Controls.Add(this.displayPromptButton);
            this.splitContainer1.Panel1.Controls.Add(this.insertDelayButton);
            this.splitContainer1.Panel1.Controls.Add(this.nextVialButton);
            this.splitContainer1.Panel1.Controls.Add(this.openCupButton);
            this.splitContainer1.Panel1.Controls.Add(this.stopFanButton);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.undoTactileButton);
            this.splitContainer1.Panel1.Controls.Add(this.startFanButton);
            this.splitContainer1.Panel1.Controls.Add(this.functionTitle1);
            this.splitContainer1.Panel1.Controls.Add(this.goToVialButton);
            this.splitContainer1.Panel1.Controls.Add(this.setRpmButton);
            this.splitContainer1.Panel1.Controls.Add(this.anticlockwiseButton);
            this.splitContainer1.Panel1.Controls.Add(this.stopStirringButton);
            this.splitContainer1.Panel1.Controls.Add(this.clockwiseButton);
            this.splitContainer1.Panel1.Controls.Add(this.startStirringButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.actionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.timeTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.messageTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(696, 432);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 1;
            // 
            // displayPromptInput
            // 
            this.displayPromptInput.Location = new System.Drawing.Point(122, 324);
            this.displayPromptInput.Name = "displayPromptInput";
            this.displayPromptInput.Size = new System.Drawing.Size(101, 23);
            this.displayPromptInput.TabIndex = 2;
            // 
            // insertDelayInput
            // 
            this.insertDelayInput.Location = new System.Drawing.Point(122, 295);
            this.insertDelayInput.Name = "insertDelayInput";
            this.insertDelayInput.Size = new System.Drawing.Size(101, 23);
            this.insertDelayInput.TabIndex = 2;
            // 
            // goToVialInput
            // 
            this.goToVialInput.Location = new System.Drawing.Point(122, 207);
            this.goToVialInput.Name = "goToVialInput";
            this.goToVialInput.Size = new System.Drawing.Size(101, 23);
            this.goToVialInput.TabIndex = 2;
            // 
            // rpmInput
            // 
            this.rpmInput.Location = new System.Drawing.Point(122, 90);
            this.rpmInput.Name = "rpmInput";
            this.rpmInput.Size = new System.Drawing.Size(101, 23);
            this.rpmInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vial:";
            // 
            // prevVialButton
            // 
            this.prevVialButton.Location = new System.Drawing.Point(122, 178);
            this.prevVialButton.Name = "prevVialButton";
            this.prevVialButton.Size = new System.Drawing.Size(101, 23);
            this.prevVialButton.TabIndex = 0;
            this.prevVialButton.Text = "Prev. Vial";
            this.prevVialButton.UseVisualStyleBackColor = true;
            this.prevVialButton.Click += new System.EventHandler(this.prevVialButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Global Control:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Accelerator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cooling:";
            // 
            // loadCalibButton
            // 
            this.loadCalibButton.Location = new System.Drawing.Point(122, 353);
            this.loadCalibButton.Name = "loadCalibButton";
            this.loadCalibButton.Size = new System.Drawing.Size(101, 23);
            this.loadCalibButton.TabIndex = 0;
            this.loadCalibButton.Text = "Load Calib. File";
            this.loadCalibButton.UseVisualStyleBackColor = true;
            this.loadCalibButton.Click += new System.EventHandler(this.loadCalibButton_Click);
            // 
            // waitForUserButton
            // 
            this.waitForUserButton.Location = new System.Drawing.Point(15, 353);
            this.waitForUserButton.Name = "waitForUserButton";
            this.waitForUserButton.Size = new System.Drawing.Size(101, 23);
            this.waitForUserButton.TabIndex = 0;
            this.waitForUserButton.Text = "Wait for User";
            this.waitForUserButton.UseVisualStyleBackColor = true;
            this.waitForUserButton.Click += new System.EventHandler(this.waitForUserButton_Click);
            // 
            // clsoeCupButton
            // 
            this.clsoeCupButton.Enabled = false;
            this.clsoeCupButton.Location = new System.Drawing.Point(122, 251);
            this.clsoeCupButton.Name = "clsoeCupButton";
            this.clsoeCupButton.Size = new System.Drawing.Size(101, 23);
            this.clsoeCupButton.TabIndex = 0;
            this.clsoeCupButton.Text = "Close Cup";
            this.clsoeCupButton.UseVisualStyleBackColor = true;
            this.clsoeCupButton.Click += new System.EventHandler(this.clsoeCupButton_Click);
            // 
            // displayPromptButton
            // 
            this.displayPromptButton.Location = new System.Drawing.Point(15, 324);
            this.displayPromptButton.Name = "displayPromptButton";
            this.displayPromptButton.Size = new System.Drawing.Size(101, 23);
            this.displayPromptButton.TabIndex = 0;
            this.displayPromptButton.Text = "Display Prompt";
            this.displayPromptButton.UseVisualStyleBackColor = true;
            this.displayPromptButton.Click += new System.EventHandler(this.displayPromptButton_Click);
            // 
            // insertDelayButton
            // 
            this.insertDelayButton.Location = new System.Drawing.Point(15, 295);
            this.insertDelayButton.Name = "insertDelayButton";
            this.insertDelayButton.Size = new System.Drawing.Size(101, 23);
            this.insertDelayButton.TabIndex = 0;
            this.insertDelayButton.Text = "Insert Wait (S)";
            this.insertDelayButton.UseVisualStyleBackColor = true;
            this.insertDelayButton.Click += new System.EventHandler(this.insertDelayButton_Click);
            // 
            // nextVialButton
            // 
            this.nextVialButton.Location = new System.Drawing.Point(15, 178);
            this.nextVialButton.Name = "nextVialButton";
            this.nextVialButton.Size = new System.Drawing.Size(101, 23);
            this.nextVialButton.TabIndex = 0;
            this.nextVialButton.Text = "Next Vial";
            this.nextVialButton.UseVisualStyleBackColor = true;
            this.nextVialButton.Click += new System.EventHandler(this.nextVialButton_Click);
            // 
            // openCupButton
            // 
            this.openCupButton.Enabled = false;
            this.openCupButton.Location = new System.Drawing.Point(15, 251);
            this.openCupButton.Name = "openCupButton";
            this.openCupButton.Size = new System.Drawing.Size(101, 23);
            this.openCupButton.TabIndex = 0;
            this.openCupButton.Text = "Open Cup";
            this.openCupButton.UseVisualStyleBackColor = true;
            this.openCupButton.Click += new System.EventHandler(this.openCupButton_Click);
            // 
            // stopFanButton
            // 
            this.stopFanButton.Location = new System.Drawing.Point(124, 134);
            this.stopFanButton.Name = "stopFanButton";
            this.stopFanButton.Size = new System.Drawing.Size(101, 23);
            this.stopFanButton.TabIndex = 0;
            this.stopFanButton.Text = "Stop Fan";
            this.stopFanButton.UseVisualStyleBackColor = true;
            this.stopFanButton.Click += new System.EventHandler(this.stopFanButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(122, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // undoTactileButton
            // 
            this.undoTactileButton.Location = new System.Drawing.Point(15, 397);
            this.undoTactileButton.Name = "undoTactileButton";
            this.undoTactileButton.Size = new System.Drawing.Size(101, 23);
            this.undoTactileButton.TabIndex = 0;
            this.undoTactileButton.Text = "Undo";
            this.undoTactileButton.UseVisualStyleBackColor = true;
            this.undoTactileButton.Click += new System.EventHandler(this.undoTactileButton_Click);
            // 
            // startFanButton
            // 
            this.startFanButton.Location = new System.Drawing.Point(15, 134);
            this.startFanButton.Name = "startFanButton";
            this.startFanButton.Size = new System.Drawing.Size(101, 23);
            this.startFanButton.TabIndex = 0;
            this.startFanButton.Text = "Start Fan";
            this.startFanButton.UseVisualStyleBackColor = true;
            this.startFanButton.Click += new System.EventHandler(this.startFanButton_Click);
            // 
            // functionTitle1
            // 
            this.functionTitle1.AutoSize = true;
            this.functionTitle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTitle1.Location = new System.Drawing.Point(12, 14);
            this.functionTitle1.Name = "functionTitle1";
            this.functionTitle1.Size = new System.Drawing.Size(53, 15);
            this.functionTitle1.TabIndex = 1;
            this.functionTitle1.Text = "Stir-Bar:";
            // 
            // goToVialButton
            // 
            this.goToVialButton.Location = new System.Drawing.Point(15, 207);
            this.goToVialButton.Name = "goToVialButton";
            this.goToVialButton.Size = new System.Drawing.Size(101, 23);
            this.goToVialButton.TabIndex = 0;
            this.goToVialButton.Text = "Go to Vial #";
            this.goToVialButton.UseVisualStyleBackColor = true;
            this.goToVialButton.Click += new System.EventHandler(this.goToVialButton_Click);
            // 
            // setRpmButton
            // 
            this.setRpmButton.Location = new System.Drawing.Point(15, 90);
            this.setRpmButton.Name = "setRpmButton";
            this.setRpmButton.Size = new System.Drawing.Size(101, 23);
            this.setRpmButton.TabIndex = 0;
            this.setRpmButton.Text = "Set RPM";
            this.setRpmButton.UseVisualStyleBackColor = true;
            this.setRpmButton.Click += new System.EventHandler(this.setRpmButton_Click);
            // 
            // anticlockwiseButton
            // 
            this.anticlockwiseButton.Location = new System.Drawing.Point(122, 61);
            this.anticlockwiseButton.Name = "anticlockwiseButton";
            this.anticlockwiseButton.Size = new System.Drawing.Size(101, 23);
            this.anticlockwiseButton.TabIndex = 0;
            this.anticlockwiseButton.Text = "AntiClockwise";
            this.anticlockwiseButton.UseVisualStyleBackColor = true;
            this.anticlockwiseButton.Click += new System.EventHandler(this.anticlockwiseButton_Click);
            // 
            // stopStirringButton
            // 
            this.stopStirringButton.Location = new System.Drawing.Point(122, 32);
            this.stopStirringButton.Name = "stopStirringButton";
            this.stopStirringButton.Size = new System.Drawing.Size(101, 23);
            this.stopStirringButton.TabIndex = 0;
            this.stopStirringButton.Text = "Stop Stirring";
            this.stopStirringButton.UseVisualStyleBackColor = true;
            this.stopStirringButton.Click += new System.EventHandler(this.stopStirringButton_Click);
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.Location = new System.Drawing.Point(15, 61);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(101, 23);
            this.clockwiseButton.TabIndex = 0;
            this.clockwiseButton.Text = "Clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = true;
            this.clockwiseButton.Click += new System.EventHandler(this.clockwiseButton_Click);
            // 
            // startStirringButton
            // 
            this.startStirringButton.Location = new System.Drawing.Point(15, 32);
            this.startStirringButton.Name = "startStirringButton";
            this.startStirringButton.Size = new System.Drawing.Size(101, 23);
            this.startStirringButton.TabIndex = 0;
            this.startStirringButton.Text = "Start Stirring";
            this.startStirringButton.UseVisualStyleBackColor = true;
            this.startStirringButton.Click += new System.EventHandler(this.startStirringButton_Click);
            // 
            // actionTextBox
            // 
            this.actionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.actionTextBox.Location = new System.Drawing.Point(3, 32);
            this.actionTextBox.Name = "actionTextBox";
            this.actionTextBox.ReadOnly = true;
            this.actionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.actionTextBox.Size = new System.Drawing.Size(182, 388);
            this.actionTextBox.TabIndex = 1;
            this.actionTextBox.Text = "";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeTextBox.Location = new System.Drawing.Point(374, 32);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.timeTextBox.Size = new System.Drawing.Size(74, 388);
            this.timeTextBox.TabIndex = 1;
            this.timeTextBox.Text = "";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageTextBox.Location = new System.Drawing.Point(191, 32);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(177, 388);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time (S)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Action";
            // 
            // TimesheetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 457);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TimesheetEditor";
            this.Text = "BioBox Timesheet";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += TimesheetEditor_FormClosing;

        }

        private void TimesheetEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton helpButton;
        private System.Windows.Forms.ToolStripMenuItem viewDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton editButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label functionTitle1;
        private System.Windows.Forms.Button setRpmButton;
        private System.Windows.Forms.Button stopStirringButton;
        private System.Windows.Forms.Button startStirringButton;
        private System.Windows.Forms.TextBox rpmInput;
        private System.Windows.Forms.TextBox insertDelayInput;
        private System.Windows.Forms.TextBox goToVialInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prevVialButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clsoeCupButton;
        private System.Windows.Forms.Button insertDelayButton;
        private System.Windows.Forms.Button nextVialButton;
        private System.Windows.Forms.Button openCupButton;
        private System.Windows.Forms.Button stopFanButton;
        private System.Windows.Forms.Button startFanButton;
        private System.Windows.Forms.Button goToVialButton;
        private System.Windows.Forms.Button waitForUserButton;
        private System.Windows.Forms.Button displayPromptButton;
        private System.Windows.Forms.Button undoTactileButton;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.RichTextBox actionTextBox;
        private System.Windows.Forms.RichTextBox timeTextBox;
        private System.Windows.Forms.Button anticlockwiseButton;
        private System.Windows.Forms.Button clockwiseButton;
        private TextBox displayPromptInput;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button clearButton;
        private ToolStripMenuItem newToolStripMenuItem;
        private Button loadCalibButton;
    }
}