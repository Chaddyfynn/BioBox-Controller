using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BioBox_Controller
{
    public partial class TimesheetEditor : Form
    {
        private long listCounter = 1;
        private string[] commands = new string[0];
        public TimesheetEditor()
        {
            InitializeComponent();
        }

        private void appendList(string action, string time, string message, string command)
        {
            if (!string.IsNullOrWhiteSpace(actionTextBox.Text))
            {
                actionTextBox.AppendText("\r\n" +listCounter.ToString() + ". "+ action);
            }
            else
            {
                actionTextBox.AppendText(listCounter.ToString() + ". " + action);
            }
            actionTextBox.ScrollToCaret();
            if (!string.IsNullOrWhiteSpace(timeTextBox.Text))
            {
                timeTextBox.AppendText("\r\n" + time);
            }
            else
            {
                timeTextBox.AppendText(time);
            }
            timeTextBox.ScrollToCaret();
            if (!string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                messageTextBox.AppendText("\r\n" + message);
            }
            else
            {
                messageTextBox.AppendText(message);
            }
            messageTextBox.ScrollToCaret();
            Array.Resize(ref commands, commands.Length+1);
            commands[listCounter - 1] = command;
            listCounter += 1;
        }

        private void startStirringButton_Click(object sender, EventArgs e)
        {
            appendList("Start Stirring", "/", "c1", "S");
        }

        private void stopStirringButton_Click(object sender, EventArgs e)
        {
            appendList("Stop Stirring", "/", "c0", "S");
        }

        private void clockwiseButton_Click(object sender, EventArgs e)
        {
            appendList("Rotate Clockwise", "/", "r0", "S");
        }

        private void anticlockwiseButton_Click(object sender, EventArgs e)
        {
            appendList("Rotate Anticlockwise", "/", "r1", "S");
        }

        private void setRpmButton_Click(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(rpmInput.Text, out num) && (rpmInput.Text.Length > 0))
            {
                if (rpmInput.Text.Contains("-"))
                {
                    rpmInput.Text = rpmInput.Text.Substring(1);
                }
                appendList("Set RPM to " + rpmInput.Text, "/", "S" + rpmInput.Text, "S");
            }
            else
            {
                rpmDialog("RPM speed");
            }
        }

        private void rpmDialog(string type) {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Please ensure that the " + type + " you've entered is physically sensible!\n \n" +
                "It may not be negative, fractional, or contain non numeric characters."
                , "Caution!", buttons, MessageBoxIcon.Warning);
        }

        private void startFanButton_Click(object sender, EventArgs e)
        {
            appendList("Start Cooling", "/", "T1", "S");
        }

        private void stopFanButton_Click(object sender, EventArgs e)
        {
            appendList("Stop Cooling", "/", "T0", "S");
        }

        private void nextVialButton_Click(object sender, EventArgs e)
        {
            appendList("Next Vial", "/", "V0", "V");
        }

        private void prevVialButton_Click(object sender, EventArgs e)
        {
            appendList("Previous Vial", "/", "V1", "V");
        }

        private void goToVialButton_Click(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(goToVialInput.Text, out num) && (goToVialInput.Text.Length > 0))
            {
                if (goToVialInput.Text.Contains("-"))
                {
                    goToVialInput.Text = goToVialInput.Text.Substring(1);
                }
                appendList("Go to vial #" + goToVialInput.Text, "/", "P" + goToVialInput.Text, "V");
            }
            else
            {
                rpmDialog("vial number");
            }
        }

        private void openCupButton_Click(object sender, EventArgs e)
        {
            appendList("Open Faraday Cup", "/", "F1", "P");
        }

        private void clsoeCupButton_Click(object sender, EventArgs e)
        {
            appendList("Close Faraday Cup", "/", "F0", "P");
        }

        private void insertDelayButton_Click(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(insertDelayInput.Text, out num) && (insertDelayInput.Text.Length > 0))
            {
                if (insertDelayInput.Text.Contains("-"))
                {
                    insertDelayInput.Text = insertDelayInput.Text.Substring(1);
                }
                appendList("Wait for " + insertDelayInput.Text + "s", insertDelayInput.Text, "/", "D");
            }
            else
            {
                rpmDialog("wait time");
            }
        }

        private void displayPromptButton_Click(object sender, EventArgs e)
        {
            if (displayPromptInput.Text.Length <= 28)
            {
                appendList("Display Message", "/", displayPromptInput.Text, "U0");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Please ensure that your prompt messages is less than or equal to 28 characters in length (including spaces)"
                    , "Caution!", buttons, MessageBoxIcon.Warning);
            }
        }

        private void waitForUserButton_Click(object sender, EventArgs e)
        {
            appendList("Wait for User Action", "/", "/", "U1");
        }

        private void undoTactileButton_Click(object sender, EventArgs e)
        {
            messageTextBox.Lines = messageTextBox.Lines.Take(messageTextBox.Lines.Length -1).ToArray();
            timeTextBox.Lines = timeTextBox.Lines.Take(timeTextBox.Lines.Length - 1).ToArray();
            actionTextBox.Lines = actionTextBox.Lines.Take(actionTextBox.Lines.Length - 1).ToArray();
            listCounter -= 1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageTextBox.Clear();
            timeTextBox.Clear();
            actionTextBox.Clear();
            Array.Clear(commands, 0 , commands.Length);
            Array.Resize(ref commands, 0);
            listCounter = 1;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = convertTimesheetToText();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Timesheet CSV (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Timesheet";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

            }
        }

        private string[] convertTimesheetToText()
        {
            string[] output = new string[listCounter - 1];
            for (long i = 0; i < listCounter - 1; i++)
            {
                output[i] += actionTextBox.Lines[i] + "," + timeTextBox.Lines[i] + "," + messageTextBox.Lines[i] + "," + commands[i];
            }

            return output;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoTactileButton_Click(sender, e);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Timesheet CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clearButton_Click(sender, e);
                    filePath = openFileDialog.FileName;
                    var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;
                        long counter = 0;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] newStrings = line.Split(',');
                            if (!string.IsNullOrWhiteSpace(actionTextBox.Text))
                            {
                                actionTextBox.AppendText("\r\n" + newStrings[0]);
                            }
                            else
                            {
                                actionTextBox.AppendText(newStrings[0]);
                            }
                            if (!string.IsNullOrWhiteSpace(timeTextBox.Text))
                            {
                                timeTextBox.AppendText("\r\n" + newStrings[1]);
                            }
                            else
                            {
                                timeTextBox.AppendText(newStrings[1]);
                            }
                            timeTextBox.ScrollToCaret();
                            if (!string.IsNullOrWhiteSpace(messageTextBox.Text))
                            {
                                messageTextBox.AppendText("\r\n" + newStrings[2]);
                            }
                            else
                            {
                                messageTextBox.AppendText(newStrings[2]);
                            }
                            messageTextBox.ScrollToCaret();
                            Array.Resize(ref commands, commands.Length + 1);
                            commands[counter] = newStrings[3];
                            counter++;
                        }
                        listCounter = counter + 1;
                    }
                }
            }
        }

        private void viewDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("./BioBox_UI_Documentation.pdf");
        }

        private void viewSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Chaddyfynn/BioBox-Controller");
        }

        private void getTimesheetFromControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }
    }
}
