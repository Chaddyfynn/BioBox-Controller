using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BioBox_Controller
{
    public partial class PositionForm : Form
    {
        public SerialPort port; // Port object
        private bool connect = false;
        private string[] portNames;
        private string portName;

        public PositionForm()
        {
            preInitialisation();
            InitializeComponent();
            postInitiialisation();
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
                    port.Close();
                }
                catch
                {
                    Console.WriteLine(msg + "denied due to external device error! Please re-try");
                    sendToPort(msg);
                }
            }
            else
            {
                Console.WriteLine(msg + " request denied to " + portName + ". Reason: Not connected.");
            }
        }

        private void preInitialisation()
        {
            portNames = SerialPort.GetPortNames(); // Gets list of port names
            if (portNames.Length > 0)
            {
                portName = portNames[0]; // Set active port to first in array
            }
            else
            {
                portName = ""; // Set portName to empty string
            }
        }

        private void postInitiialisation()
        {
            activePortText.Text = portName;
            portSelect.DataSource = portNames;  // Set the dropdown menu texts to the portNames array
            port = new SerialPort();
            port.BaudRate = 9600;
        }

        private void applyCalibButton_Click(object sender, EventArgs e)
        {
            bool arrayIncomplete = false;
            String[] callibArray =
            {
                input1.Text,
                input2.Text,
                input3.Text,
                input4.Text,
                input5.Text,
                input6.Text,
                input7.Text,
                input8.Text,
                input9.Text,
                input10.Text,
            };
            int[] callibArrayInt = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (callibArray[i].Contains("-"))
                    {
                        callibArray[i] = callibArray[i].Substring(1);
                    }
                    if (callibArray[i] == "" || ((callibArray[i] == "0") && (i > 0 && i != 10)))
                    {
                        arrayIncomplete = true;
                        continue;
                    }
                    callibArrayInt[i] = int.Parse(callibArray[i]);
                }
                if (arrayIncomplete)
                {
                    int range = callibArrayInt[9] - callibArrayInt[0];
                    int step = range / 10;
                    int dutyCycle = callibArrayInt[0];
                    for (int i = 0; i < 10; i++)
                    {
                        if (callibArray[i] == "" || ((callibArray[i] == "0") && (i > 0 && i != 10)))
                        {
                            callibArrayInt[i] = dutyCycle;
                        }
                        dutyCycle += step;
                    }
                }
                input1.Text = callibArrayInt[0].ToString();
                input2.Text = callibArrayInt[1].ToString();
                input3.Text = callibArrayInt[2].ToString();
                input4.Text = callibArrayInt[3].ToString();
                input5.Text = callibArrayInt[4].ToString();
                input6.Text = callibArrayInt[5].ToString();
                input7.Text = callibArrayInt[6].ToString();
                input8.Text = callibArrayInt[7].ToString();
                input9.Text = callibArrayInt[8].ToString();
                input10.Text = callibArrayInt[9].ToString();

                for (int i = 0; i < 10; i++)
            {
                    sendToPort("C" + i.ToString() + "D" + callibArrayInt[i].ToString());
                    Console.WriteLine("C" + i.ToString() + "D" + callibArrayInt[i].ToString() + "\n\n" + "Sent!");
                    Thread.Sleep(5);
            }
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Please ensure all of your inputted values are numeric, and sensible.\n\n" +
                    "You must fill in duty cycles for at least Vial 1 and Vial 10.", "WARNING!", buttons, MessageBoxIcon.Warning);
            }
            
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
                statusText.Text = "Connected";
                port.PortName = portName;
                // port.Open();
            }
            else
            {
                connect = false;
                statusText.Text = "User Abort";
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            portNames = SerialPort.GetPortNames();
            portSelect.DataSource = portNames;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectDialog();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            connect = false;
            statusText.Text = "Disconnected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendToPort("P1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendToPort("P2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendToPort("P3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendToPort("P4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sendToPort("P5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sendToPort("P6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sendToPort("P7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sendToPort("P8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sendToPort("P9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sendToPort("P10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sendToPort("P11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sendToPort("P12");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sendToPort("V0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sendToPort("V1");
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Callibration CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
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
                            input1.Text = newStrings[0];
                            input2.Text = newStrings[1];
                            input3.Text = newStrings[2];
                            input4.Text = newStrings[3];
                            input5.Text = newStrings[4];
                            input6.Text = newStrings[5];
                            input7.Text = newStrings[6];
                            input8.Text = newStrings[7];
                            input9.Text = newStrings[8];
                            input10.Text = newStrings[9];
                            counter++;
                        }
                    }
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string line = convertCallibToText();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Timesheet CSV (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Timesheet";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    outputFile.WriteLine(line);
                }

            }
        }

        private string convertCallibToText()
        {
            string output =
                input1.Text + "," +
                input2.Text + "," +
                input3.Text + "," +
                input4.Text + "," +
                input5.Text + "," +
                input6.Text + "," +
                input7.Text + "," +
                input8.Text + "," +
                input9.Text + "," +
                input10.Text;
            return output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
            input4.Text = "";
            input5.Text = "";
            input6.Text = "";
            input7.Text = "";
            input8.Text = "";
            input9.Text = "";
            input10.Text = "";
        }
    }
}
