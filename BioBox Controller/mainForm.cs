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
        public SerialPort port;
        private string[] portNames;
        private string portName;
        private string speed;
        private string delay;
        private string runTime;
        private bool useRunTime;
        private bool delayed = false;
        private int time = 0;
        private int countdown;
        private bool connect = false;

        public mainForm()
        {
            portNames = SerialPort.GetPortNames();
            portName = portNames[0];
            InitializeComponent();
            portSelect.DataSource = portNames;
            activePortText.Text = portName;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void sendToPort(string msg)
        {
            if (connect)
            {
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine(msg);
                Console.WriteLine(msg + " sent to port " + portName);
                consoleText.Text = msg + " send to port " + portName;
                port.Close();
            }
            else
            {
                Console.WriteLine(msg + " request denied to " + portName + ". Reason: Not connected.");
                consoleText.Text = msg + " denied to  " + portName + ". Not connected.";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            sendToPort("c0"); //c0: control 0 - stop
            delayed = false;
            time += 1;
            elapsedText.Text = time.ToString();
            elapsedText.Text += " s";
            time = 0;
            timer.Enabled = false;
            runningStatus.Text = "Finished";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int num;
            Console.WriteLine("Start pressed...");
            consoleText.Text = "Start pressed...";
            if (int.TryParse(delay, out num) && (delay != "0"))
            {
                Console.WriteLine("Delayed for " + num);
                consoleText.Text = "Delayed for " + num;
                countdown = num;
                delayTimer.Interval = num * 1000;
                countdownTimer.Enabled = true;
                delayTimer.Enabled = true;
                countdownText.Text = num.ToString() + " s";
                runningStatus.Text = "Delayed";
            }
            else
            {
                sendToPort("c1"); //c1: control 1 - start
                timer.Enabled = true;
                countdownText.Text = "N/A";
                elapsedText.Text = "0 s";
                if (useRunTime)
                {
                    runTimer.Interval = int.Parse(runTime) * 1000;
                    runTimer.Enabled = true;
                }
                runningStatus.Text = "Running";
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            sendToPort("f0"); //f0: function 0 - rotate
            modeText.Text = "Rotate";
        }

        private void vibrateButton_Click(object sender, EventArgs e)
        {
            sendToPort("f1"); //f1: function 1 - vibrate
            modeText.Text = "Vibrate";
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            portSelect.DataSource = portNames;
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            portName = portSelect.Text;
            activePortText.Text = portName;
            Console.WriteLine("LOG: Port updated - " + portName);
            consoleText.Text = "LOG: Port updated - " + portName;
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
            delayed = false;
            delayTimer.Enabled = false;
            countdownTimer.Enabled = false;
            timer.Enabled = true;
            countdownText.Text = "0 s";
            elapsedText.Text = "0 s";
            if (useRunTime)
            {
                runTimer.Interval = int.Parse(runTime) * 1000;
                runTimer.Enabled = true;
            }
            runningStatus.Text = "Running";
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            sendToPort("T0");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connect = true;
            statusText.Text = "Connected";
            statusText2.Text = "Connected";
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
        }
    }
}
