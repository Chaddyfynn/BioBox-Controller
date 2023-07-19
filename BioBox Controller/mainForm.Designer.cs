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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.functionText = new System.Windows.Forms.Label();
            this.rotateButton = new System.Windows.Forms.Button();
            this.vibrateButton = new System.Windows.Forms.Button();
            this.variableText = new System.Windows.Forms.Label();
            this.frequencyText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.applyGeneralButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.anticlockwiseButton = new System.Windows.Forms.Button();
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.timerText = new System.Windows.Forms.Label();
            this.runTimeText = new System.Windows.Forms.Label();
            this.delayText = new System.Windows.Forms.Label();
            this.delayInput = new System.Windows.Forms.TextBox();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.runTimeInput = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.externalControlText = new System.Windows.Forms.Label();
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
            this.tabControl.Size = new System.Drawing.Size(266, 370);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.frequencyText);
            this.tabPage1.Controls.Add(this.stopButton);
            this.tabPage1.Controls.Add(this.stepButton);
            this.tabPage1.Controls.Add(this.clockwiseButton);
            this.tabPage1.Controls.Add(this.anticlockwiseButton);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.applyGeneralButton);
            this.tabPage1.Controls.Add(this.vibrateButton);
            this.tabPage1.Controls.Add(this.rotateButton);
            this.tabPage1.Controls.Add(this.variableText);
            this.tabPage1.Controls.Add(this.functionText);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearButton);
            this.tabPage2.Controls.Add(this.applySettingsButton);
            this.tabPage2.Controls.Add(this.runTimeInput);
            this.tabPage2.Controls.Add(this.delayInput);
            this.tabPage2.Controls.Add(this.delayText);
            this.tabPage2.Controls.Add(this.runTimeText);
            this.tabPage2.Controls.Add(this.externalControlText);
            this.tabPage2.Controls.Add(this.timerText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // functionText
            // 
            this.functionText.AutoSize = true;
            this.functionText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionText.Location = new System.Drawing.Point(3, 3);
            this.functionText.Name = "functionText";
            this.functionText.Size = new System.Drawing.Size(96, 15);
            this.functionText.TabIndex = 0;
            this.functionText.Text = "Motor Function:";
            // 
            // rotateButton
            // 
            this.rotateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rotateButton.Location = new System.Drawing.Point(6, 21);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(75, 23);
            this.rotateButton.TabIndex = 1;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // vibrateButton
            // 
            this.vibrateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibrateButton.Location = new System.Drawing.Point(87, 21);
            this.vibrateButton.Name = "vibrateButton";
            this.vibrateButton.Size = new System.Drawing.Size(75, 23);
            this.vibrateButton.TabIndex = 1;
            this.vibrateButton.Text = "Vibrate";
            this.vibrateButton.UseVisualStyleBackColor = true;
            this.vibrateButton.Click += new System.EventHandler(this.vibrateButton_Click);
            // 
            // variableText
            // 
            this.variableText.AutoSize = true;
            this.variableText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableText.Location = new System.Drawing.Point(3, 63);
            this.variableText.Name = "variableText";
            this.variableText.Size = new System.Drawing.Size(97, 15);
            this.variableText.TabIndex = 0;
            this.variableText.Text = "Motor Variables:";
            // 
            // frequencyText
            // 
            this.frequencyText.AutoSize = true;
            this.frequencyText.Location = new System.Drawing.Point(6, 84);
            this.frequencyText.Name = "frequencyText";
            this.frequencyText.Size = new System.Drawing.Size(62, 15);
            this.frequencyText.TabIndex = 2;
            this.frequencyText.Text = "Frequency";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // applyGeneralButton
            // 
            this.applyGeneralButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyGeneralButton.Location = new System.Drawing.Point(171, 185);
            this.applyGeneralButton.Name = "applyGeneralButton";
            this.applyGeneralButton.Size = new System.Drawing.Size(75, 23);
            this.applyGeneralButton.TabIndex = 1;
            this.applyGeneralButton.Text = "Apply";
            this.applyGeneralButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(9, 313);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stepButton.Location = new System.Drawing.Point(9, 284);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 1;
            this.stepButton.Text = "Single Step";
            this.stepButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Location = new System.Drawing.Point(90, 284);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 52);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // anticlockwiseButton
            // 
            this.anticlockwiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anticlockwiseButton.Location = new System.Drawing.Point(171, 313);
            this.anticlockwiseButton.Name = "anticlockwiseButton";
            this.anticlockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.anticlockwiseButton.TabIndex = 1;
            this.anticlockwiseButton.Text = "Anti-Clockwise";
            this.anticlockwiseButton.UseVisualStyleBackColor = true;
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clockwiseButton.Location = new System.Drawing.Point(171, 284);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(75, 23);
            this.clockwiseButton.TabIndex = 1;
            this.clockwiseButton.Text = "Clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = true;
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
            this.timerText.Click += new System.EventHandler(this.timerText_Click);
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
            // delayText
            // 
            this.delayText.AutoSize = true;
            this.delayText.Location = new System.Drawing.Point(6, 25);
            this.delayText.Name = "delayText";
            this.delayText.Size = new System.Drawing.Size(52, 15);
            this.delayText.TabIndex = 1;
            this.delayText.Text = "Delay (s)";
            // 
            // delayInput
            // 
            this.delayInput.Location = new System.Drawing.Point(90, 22);
            this.delayInput.Name = "delayInput";
            this.delayInput.Size = new System.Drawing.Size(100, 23);
            this.delayInput.TabIndex = 2;
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(177, 313);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 3;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            // 
            // runTimeInput
            // 
            this.runTimeInput.Location = new System.Drawing.Point(90, 51);
            this.runTimeInput.Name = "runTimeInput";
            this.runTimeInput.Size = new System.Drawing.Size(100, 23);
            this.runTimeInput.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(177, 80);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // externalControlText
            // 
            this.externalControlText.AutoSize = true;
            this.externalControlText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.externalControlText.Location = new System.Drawing.Point(6, 108);
            this.externalControlText.Name = "externalControlText";
            this.externalControlText.Size = new System.Drawing.Size(100, 15);
            this.externalControlText.TabIndex = 0;
            this.externalControlText.Text = "External Control:";
            this.externalControlText.Click += new System.EventHandler(this.timerText_Click);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(288, 391);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "BioBox Controller";
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
        private System.Windows.Forms.Button vibrateButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Label variableText;
        private System.Windows.Forms.Label functionText;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label externalControlText;
    }
}

