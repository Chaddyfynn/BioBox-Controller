using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBox_Controller
{
    public partial class ControlForm : Form
    {
        private PositionForm positionForm = new PositionForm();
        private TimesheetEditor editor = new TimesheetEditor();
        private mainForm mainForm = new mainForm();
        public SerialPort motorPort; // Port object
        public SerialPort vialPort; // Port object
        public static string[] commands = new string[0];
        public static string[] times = new string[0];
        public static string[] messages = new string[0];
        public static string[] actions = new string[0];
        private bool running = false;
        private bool paused = false;
        private bool fileLoaded = false;
        private int currentActionIndex = 0;
        private int currentTime;
        private string currentCommand;
        private string currentMessage;
        private int defaultTime = 5;
        private int runtime = 0;
        private int delayTime = 0;
        private bool connect = false;
        private string[] motorPortNames;
        private string[] vialPortNames;
        private string motorPortName;
        private string vialPortName;
        private bool delayed = false;
        private bool notProcessing = true;

        public ControlForm()
        {
            vialPortNames = SerialPort.GetPortNames();
            motorPortNames = SerialPort.GetPortNames();
            if (motorPortNames.Length > 0)
            {
                motorPortName = motorPortNames[0]; // Set active port to first in array
                vialPortName = vialPortNames[0]; // Set active port to first in array
            }
            else
            {
                motorPortName = ""; // Set portName to empty string
                vialPortName = ""; // Set portName to empty string
            }
            InitializeComponent(); // Build the form
            motorPortSelect.DataSource = motorPortNames;  // Set the dropdown menu texts to the portNames array
            vialPortSelect.DataSource = vialPortNames;  // Set the dropdown menu texts to the portNames array
            motorPortActive.Text = motorPortName; // set the active port label to the selected port
            vialPortActive.Text = vialPortName;
            motorPort = new SerialPort();
            motorPort.BaudRate = 9600;
            vialPort = new SerialPort();
            vialPort.BaudRate = 9600;
        }


        private void vialControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionForm.Show();
        }

        private void stirBarControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm.Show();
        }

        private void timesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Show();
        }

        private void viewDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("BioBox_UI_Documentation.pdf");
        }

        private void viewSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Chaddyfynn/BioBox-Controller");
        }

        private void openTimesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                clearMem();
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Timesheet CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    timesheetText.Text = filePath;
                    statusStat.Text = "Active File";
                    var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;
                        long counter = 0;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] newStrings = line.Split(',');
                            Array.Resize(ref commands, commands.Length + 1);
                            Array.Resize(ref times, times.Length + 1); 
                            Array.Resize(ref messages, messages.Length + 1);
                            Array.Resize(ref actions, actions.Length + 1);
                            commands[counter] = newStrings[3];
                            times[counter] = newStrings[1];
                            messages[counter] = newStrings[2];
                            actions[counter] = newStrings[0];
                            counter++;
                        }
                    }
                    nextActionStat.Text = actions[currentActionIndex];
                    fileLoaded = true;
                }
            }
            
        }

        private void clearMem()
        {
            Array.Clear(commands, 0, commands.Length); 
            Array.Clear(times, 0, times.Length);
            Array.Clear(messages, 0, messages.Length);
            Array.Clear(actions, 0, actions.Length);
            Array.Resize(ref commands, 0);
            Array.Resize(ref times, 0);
            Array.Resize(ref messages, 0);
            Array.Resize(ref actions, 0);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (fileLoaded && notProcessing)
            {
                currentActionIndex = 0;
                experimentTimer.Enabled = true;
                experimentTimer.Interval = defaultTime;
                runTimer.Enabled = true;
                running = true;
                delayed = false;
                statusStat.Text = "Running";
            }
        }

        private void experimentTimer_Tick(object sender, EventArgs e)
        {
            if (fileLoaded && notProcessing)
            {
                int num;
                currentCommand = commands[currentActionIndex];
                currentMessage = messages[currentActionIndex];

                if (int.TryParse(times[currentActionIndex], out num) && (num > 0))
                {
                    currentTime = num * 1000;
                }
                else
                {
                    currentTime = defaultTime;
                    experimentTimer.Interval = defaultTime;
                }

                if (currentCommand == "D")
                {
                    experimentTimer.Interval = currentTime;
                    delayTime = currentTime / 1000;
                    delayTimer.Enabled = true;
                    lastActionStat.Text = nextActionStat.Text;
                    nextActionStat.Text = actions[currentActionIndex];
                }
                else
                {
                    delayTimer.Enabled = false;
                    runAction(currentCommand, currentMessage);
                }
                currentActionIndex++;
                if (currentActionIndex == messages.Length)
                {
                    stopButton_Click(sender, e);
                }
            }
        }

        private void runAction(string command, string message) {
            {
                notProcessing = false;
                if (command[0] == 'S')
                {
                    command = command.Substring(1);
                    sendToPort(message, true);
                    if (message[0] == 'c') { if (message[1] == '0') { motorStatusStat.Text = "Stopped"; } else if (message[1] == '1') { motorStatusStat.Text = "Running"; } }
                    else if (message[0] == 'T') { if (message[1] == '0') { coolingStatusStat.Text = "Not Cooling"; } else if (message[1] == '1') { coolingStatusStat.Text = "Cool"; } }
                }
                else if (command[0] == 'V')
                {
                    command = command.Substring(1);
                    sendToPort(message, false);
                }
                else if (command[0] == 'U')
                {
                    if (command[1] == '0')
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Automated user prompt!\n\n" + "Message: " + message
                            , "User Prompt!", buttons, MessageBoxIcon.Warning);
                    }
                    else if (command[1] == '1')
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Waiting for user...\n\n" + "Press OK to continue..."
                            , "Caution!", buttons, MessageBoxIcon.Warning);
                    }
                }
                else if (command[0] == 'P')
                {
                    Console.WriteLine("P Command \n");
                }
                else
                {
                    Console.WriteLine("Unknown command \n");
                }
                lastActionStat.Text = nextActionStat.Text;
                nextActionStat.Text = actions[currentActionIndex];
                notProcessing = true;
            }
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            runtime += 1;
            runtimeStat.Text = runtime.ToString() + "s";
        }

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            delayed = true;
            delayTime -= 1;
            delayStat.Text = delayTime.ToString() + "s";
        }

        private void sendToPort(string msg, bool useMotorPort)
        {
            if (connect)
            {
                if (useMotorPort)
                {
                    try
                    {
                        motorPort.Open();
                        motorPort.WriteLine(msg);
                        Console.WriteLine(msg + " sent to port " + motorPortName);
                        motorPort.Close();
                    }
                    catch
                    {
                        sendToPort(msg, true);
                    }
                }
                else
                {
                    try
                    {
                        vialPort.Open();
                        vialPort.WriteLine(msg);
                        Console.WriteLine(msg + " sent to port " + vialPortName);
                        vialPort.Close();
                    }
                    catch
                    {
                        sendToPort(msg, false);
                    }
                    
                }
            }
            else
            {
                Console.WriteLine(msg + " request denied. Reason: Not connected.");

            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("You must be sure you are connecting to the correct COM port before continuing... \n \n" +
                " Connecting to the wrong COM port will cause the app to crash on sending a request.\n \n Do you want to continue?", "WARNING!", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                connect = true;
                vialPortName = vialPortSelect.Text;
                motorPortName = motorPortSelect.Text;
                motorPortActive.Text = motorPortSelect.Text;
                vialPortActive.Text = vialPortSelect.Text;
                motorPortStatus.Text = "Connected";
                vialPortStatus.Text = "Connected";
                motorPort.PortName = motorPortName;
                vialPort.PortName = vialPortName;
            }
            else
            {
                connect = false;
                motorPortStatus.Text = "User Abort";
                vialPortStatus.Text = "User Abort";
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            connect = false;
            motorPortStatus.Text = "Disconnected";
            vialPortStatus.Text = "Disconnected";
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            vialPortNames = SerialPort.GetPortNames();
            motorPortNames = SerialPort.GetPortNames();
            motorPortSelect.DataSource = motorPortNames;
            vialPortSelect.DataSource = vialPortNames;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                if (delayed)
                {
                    delayed = false;
                    delayTimer.Enabled = false;
                }
                runTimer.Enabled = false;
                experimentTimer.Enabled = false;
                runtime = 0;
                runtimeStat.Text = "0s";
                delayStat.Text = "0s";
                currentActionIndex = 0;
                experimentTimer.Interval = defaultTime;
                nextActionStat.Text = actions[currentActionIndex];
                running = false;
                statusStat.Text = "Finished!";
                notProcessing = true;
                //sendToPort("T0", true);
                coolingStatusStat.Text = "Not Cooling";
                //sendToPort("c0", true);
                motorStatusStat.Text = "Not Running";
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                if (delayed)
                {
                    delayTimer.Enabled = true;
                    statusStat.Text = "Running";
                }
                else
                {
                    statusStat.Text = "Running";
                }
                runTimer.Enabled = true;
                experimentTimer.Enabled = true;
                paused = false;
            }
            else if (running)
            {
                statusStat.Text = "Paused";
                runTimer.Enabled = false;
                delayTimer.Enabled = false;
                experimentTimer.Enabled = false;
                paused = true;
            }
        }

        private void anticlockwiseButton_Click(object sender, EventArgs e)
        {
            if (notProcessing)
            {
                sendToPort("r1", true);
            }
        }

        private void clockwiseButton_Click(object sender, EventArgs e)
        {
            if (notProcessing)
            {
                sendToPort("r0", true);
            }
        }

        private void nextVialButton_Click(object sender, EventArgs e)
        {
            if (notProcessing)
            {
                sendToPort("V0", false);
            }
        }

        private void prevVialButton_Click(object sender, EventArgs e)
        {
            if (notProcessing)
            {
                sendToPort("V1", false);
            }
        }
    }

}
