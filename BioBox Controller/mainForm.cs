using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace BioBox_Controller
{
    public partial class mainForm : Form
    {
        // Class attribute declarations
        public SerialPort port; // Port object
        private string[] portNames; // Array of available ports
        private string portName; // Currently selected port
        private string speed; // Currently selected motor speed
        private string delay; // Currently selected delay
        private string runTime; // Currently selected run time
        private bool useRunTime; // Bool for if run time should be used 
        private bool delayed = false; // Bool for if delay is active
        private int time = 0; // Current time elapsed
        private int countdown; // Current delay countdown time
        private bool connect = false; // Bool for if app should connect to port
        private bool runFan = false;
        private bool fanRunning = false;
        private string fanTime;

        public mainForm()
        {
            portNames = SerialPort.GetPortNames(); // Gets list of port names
            if (portNames.Length > 0 )
            {
                portName = portNames[0]; // Set active port to first in array
            }
            else
            {
                portName = ""; // Set portName to empty string
            }
            InitializeComponent(); // Build the form
            portSelect.DataSource = portNames;  // Set the dropdown menu texts to the portNames array
            activePortText.Text = portName; // set the active port label to the selected port
            port = new SerialPort();
            port.BaudRate = 9600;
        }

        private void sendToPort(string msg) // Sends the argument to the active port
        {
            if (connect)
            {
                try
                {
                    port.Open();
                    port.WriteLine(msg);
                    Console.WriteLine(msg + " sent to port " + portName);
                    consoleText.Text = msg + " send to port " + portName;
                    port.Close();
                }
                catch
                {
                    Console.WriteLine(msg + "denied due to external device error! Please re-try");
                    consoleText.Text = msg + "denied due to external device error! Please re-try";
                    sendToPort(msg);
                }
            }
            else
            {
                Console.WriteLine(msg + " request denied to " + portName + ". Reason: Not connected.");
                consoleText.Text = msg + " denied to  " + portName + ". Not connected.";
            }
        }

        private void stopButton_Click(object sender, EventArgs e) // Stop Button Click
        {
            if (delayed)
            {
                delayTimer.Enabled = false;
                countdownTimer.Enabled = false;
                runningStatus.Text = "Cancelled";
            }
            else
            {
                runningStatus.Text = "Finished";
            }
            sendToPort("c0"); // Send c0 message
            delayed = false;
            time += 1;
            elapsedText.Text = time.ToString();
            elapsedText.Text += " s";
            time = 0;
            timer.Enabled = false;
            applySettingsButton.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = true;
            if (fanTimer.Enabled)
            {
                sendToPort("T0");
                fanTimer.Enabled = false;
                fanRunning = false;
                fanStatusText.Text = "Not Running";
            }
            else
            {
                fanTimer.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e) // Start Button Click
        {
            bool startDialogReturn = true;
            if (!connect) { startDialogReturn = startDialog(); }
            if (startDialogReturn)
            {
                int num;
                Console.WriteLine("Start pressed...");
                consoleText.Text = "Start pressed...";
                if (delayed)
                {
                    delayTimer.Enabled = false;
                    time = 0;
                    countdown = int.Parse(delay);
                    elapsedText.Text = "0 s";
                }
                if (int.TryParse(delay, out num) && (delay != "0"))
                {
                    timer.Enabled = false;
                    elapsedText.Text = "0 s";
                    delayTimer.Enabled = false;
                    runTimer.Enabled = false;
                    Console.WriteLine("Delayed for " + num + " s");
                    consoleText.Text = "Delayed for " + num + " s";
                    countdown = num;
                    delayTimer.Interval = num * 1000;
                    countdownTimer.Enabled = true;
                    delayTimer.Enabled = true;
                    countdownText.Text = num.ToString() + " s";
                    runningStatus.Text = "Delayed";
                    delayed = true;
                }
                else
                {
                    sendToPort("c1"); //c1: control 1 - start
                    timer.Enabled = true;
                    countdownText.Text = "N/A";
                    elapsedText.Text = "0 s";
                    if (useRunTime && (runTime != "0"))
                    {
                        runTimer.Interval = int.Parse(runTime) * 1000;
                        runTimer.Enabled = true;
                    }
                    runningStatus.Text = "Running";
                    if (runFan && !(fanTimer.Enabled))
                    {
                        sendToPort("T1");
                        fanRunning = true;
                        fanStatusText.Text = "Running";
                    }
                    else if (runFan && (fanTimer.Enabled))
                    {
                        fanTimer.Enabled = false;
                    }
                }
                applySettingsButton.Enabled = false;
                connectButton.Enabled = false;
                disconnectButton.Enabled = false;
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            portNames = SerialPort.GetPortNames();
            portSelect.DataSource = portNames;
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            if (portSelect.SelectedItem.ToString() != portName)
            {
                connectDialog();
            }
            long num;
            if ((delayInput.Text.Length > 0) && long.TryParse(delayInput.Text, out num))
            {
                if (delayInput.Text.Contains("-"))
                {
                    delayInput.Text = delayInput.Text.Substring(1);
                }
                delay = delayInput.Text;
                delayed = true;
                Console.WriteLine("LOG: Delay updated - " + delay + " s");
                consoleText.Text = "LOG: Delay updated - " + delay + " s";
            }
            else
            {
                delay = "0";
            }
            activeDelayText.Text = delay + " s";
            if ((runTimeInput.Text.Length > 0) && long.TryParse(runTimeInput.Text, out num))
            {
                if (runTimeInput.Text.Contains("-"))
                {
                    runTimeInput.Text = runTimeInput.Text.Substring(1);
                }
                runTime = runTimeInput.Text;
                Console.WriteLine("LOG: Run time updated - " + runTime + " s");
                consoleText.Text = "LOG: Run time updated - " + runTime + " s";
                useRunTime = true;
            }
            else
            {
                runTime = "N/A";
                useRunTime = false;
            }
            activeRunTimeText.Text = runTime + " s";
            if ((fanTimeInput.Text.Length > 0) && long.TryParse(fanTimeInput.Text, out num))
            {
                if (fanTimeInput.Text.Contains("-"))
                {
                    fanTimeInput.Text = fanTimeInput.Text.Substring(1);
                }
                fanTime = fanTimeInput.Text;
                Console.WriteLine("LOG: Fan cooldown updated - " + fanTime + " s");
                consoleText.Text = "LOG: Fan cooldown updated - " + fanTime + " s";
                activeFanTimeText.Text = fanTime + " s";
                int time = int.Parse(fanTime);
                if (time > 0) { fanTimer.Interval = time * 1000; }
                else {
                    fanTime = "5 s";
                    fanTimer.Interval = 5000;
                    activeFanTimeText.Text = fanTime;
                }
            }
            else
            {
                fanTime = "5 s";
                fanTimer.Interval = 5000;
                activeFanTimeText.Text = fanTime;
            }
            
        }

        private void applyGeneralButton_Click(object sender, EventArgs e)
        {
            long num;
            if ((speedInput.Text.Length > 0) && long.TryParse(speedInput.Text, out num))
            {
                if (speedInput.Text.Contains("-"))
                {
                    speedInput.Text = speedInput.Text.Substring(1);
                }
                speed = speedInput.Text;
                Console.WriteLine("LOG: Speed updated - " + speed);
                consoleText.Text = "LOG: Speed updated - " + speed;
            }
            else
            {
                speed = "0";
            }
            sendToPort("S" + speed);
            speedText.Text = speed;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            runTimeInput.Clear();
            delayInput.Clear();
            Console.WriteLine("LOG: Timer cleared");
            consoleText.Text = "LOG: Timer cleared";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            elapsedText.Text = time.ToString();
            elapsedText.Text += " s";
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdown -= 1;
            countdownText.Text = countdown.ToString();
            countdownText.Text += " s";
        }

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            sendToPort("c1");
            if (runFan && !(fanTimer.Enabled))
            {
                sendToPort("T1");
                fanRunning = true;
                fanStatusText.Text = "Running";
            }
            else if (runFan && (fanTimer.Enabled))
            {
                fanTimer.Enabled = false;
            }
            delayed = false;
            delayTimer.Enabled = false;
            countdownTimer.Enabled = false;
            timer.Enabled = true;
            countdownText.Text = "0 s";
            elapsedText.Text = "0 s";
            if (useRunTime && (runTime != "0"))
            {
                runTimer.Interval = int.Parse(runTime) * 1000;
                runTimer.Enabled = true;
            }
            runningStatus.Text = "Running";
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            if (runFan && !timer.Enabled)
            {
                runFan = false;
                stepButton.BackColor = Color.LightCoral;
            }
            else if (!runFan && !timer.Enabled)
            {
                runFan = true;
                stepButton.BackColor = Color.LightGreen;
            }
            else if (runFan && timer.Enabled)
            {
                runFan = false;
                stepButton.BackColor = Color.LightCoral;
                sendToPort("T0");
            }
            else if (!runFan && timer.Enabled)
            {
                runFan = true;
                stepButton.BackColor = Color.LightGreen;
                sendToPort("T1");
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectDialog();
        }

        private void connectDialog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("You must be sure you are connecting to the correct COM port before continuing... \n \n" +
                " Connecting to the wrong COM port will cause the app to crash on sending a request.\n \n Do you want to continue?", "WARNING!", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                connect = true;
                portName = portSelect.Text;
                activePortText.Text = portName;
                Console.WriteLine("LOG: Port updated - " + portName);
                consoleText.Text = "LOG: Port updated - " + portName;
                statusText.Text = "Connected";
                statusText2.Text = "Connected";
                port.PortName = portName;
                // port.Open();
            }
            else
            {
                connect = false;
                statusText.Text = "User Abort";
                statusText2.Text = "User Abort";
            }
        }

        private bool startDialog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("There are no active port connections... \n \n" +
                " Continuing will have no action on any hardware...\n \n Do you want to continue anyway?", "User Notice!", buttons, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            connect = false;
            statusText.Text = "Disconnected";
            statusText2.Text = "Disconnected";
        }

        private void clockwiseButton_Click(object sender, EventArgs e)
        {
            sendToPort("r0");
            directionText.Text = "Clockwise";
        }

        private void anticlockwiseButton_Click(object sender, EventArgs e)
        {
            sendToPort("r1");
            directionText.Text = "Anti-Clockwise";
        }

        private void runTimer_Tick(object sender, EventArgs e)
        {
            sendToPort("c0");
            delayed = false;
            timer.Enabled = false;
            runTimer.Enabled = false;
            time += 1;
            elapsedText.Text = time.ToString();
            elapsedText.Text += " s";
            time = 0;
            runningStatus.Text = "Finished";
            applySettingsButton.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = true;
            fanTimer.Enabled = true;
        }

        private void fanTimer_Tick(object sender, EventArgs e)
        {
            sendToPort("T0");
            fanRunning = false;
            fanTimer.Enabled = false;
            fanStatusText.Text = "Not Running";
        }

    }
}
