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
        private int totalVials;
        private int vialOffset = 0;

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
            bool arrayIncomplete;
            bool appendArray;
            bool minVialExists = false;
            bool maxVialExists = false;
            arrayIncomplete = !(vialDutyBox.Lines.Length == totalVials - 1);
            appendArray = (vialDutyBox.Lines.Length >= totalVials);

            int[] callibArrayInt = new int[totalVials];
            for (int i = 0; i < totalVials; i++)
            {
                callibArrayInt[i] = 0;
                Console.WriteLine("CallibArrayInt " +  i.ToString() + " is now " + "0");
            }
            for (int i = 0; i < vialNumBox.Lines.Length; i++)
            {
                Console.WriteLine("Callibrating vial number " + vialNumBox.Lines[i].ToString());
                Console.WriteLine("Callibrating to " + vialDutyBox.Lines[i].ToString());
                callibArrayInt[int.Parse(vialNumBox.Lines[i]) - 1] = int.Parse(vialDutyBox.Lines[i]);
                Console.WriteLine("Now ", int.Parse(vialNumBox.Lines[i]) - 1, "in CallibArrayInt is above");
                if (int.Parse(vialNumBox.Lines[i]) == 1) { minVialExists = true; }
                if (int.Parse(vialNumBox.Lines[i]) == totalVials) { maxVialExists = true; }
            }
            if (appendArray)
            {
                int vialNum;
                int dutyCycle;
                for (int i = totalVials; i < vialNumBox.Lines.Length; i++)
                {
                    if (int.TryParse(vialNumBox.Lines[i], out vialNum) && int.TryParse(vialDutyBox.Lines[i], out dutyCycle))
                    {
                        if (vialNum < 0) { vialNum *= -1; }
                        if (dutyCycle < 0) { dutyCycle *= -1; }
                        callibArrayInt[vialNum - 1] = dutyCycle;
                    }
                }
            }
            if (minVialExists && maxVialExists && arrayIncomplete)
            {
                clearButton_Click(sender, e);
                int arrayMin = callibArrayInt.Where(f => f > 0).Min();
                int range = callibArrayInt.Max() - arrayMin;
                int step = range / totalVials;
                int currentVial;
                int dutyCycle;
                for (int i = 0; i < totalVials; i++)
                {
                    currentVial = i + 1;
                    
                    if (callibArrayInt[i] == 0)
                    {
                        dutyCycle = arrayMin + step * i;
                        callibArrayInt[i] = dutyCycle;   
                    }
                    else { dutyCycle = callibArrayInt[i]; }
                    if (!string.IsNullOrWhiteSpace(vialNumBox.Text))
                    {
                        vialNumBox.AppendText("\r\n" + currentVial.ToString());
                    }
                    else
                    {
                        vialNumBox.AppendText(currentVial.ToString());
                    }
                    if (!string.IsNullOrWhiteSpace(vialDutyBox.Text))
                    {
                        vialDutyBox.AppendText("\r\n" + dutyCycle.ToString());
                    }
                    else
                    {
                        vialDutyBox.AppendText(dutyCycle.ToString());
                    }
                }
                arrayIncomplete = false;
            }
            if (!arrayIncomplete)
            {
                for (int i = 0; i < totalVials; i++)
                {
                    sendToPort("C" + i.ToString() + "D" + callibArrayInt[i].ToString());
                    Console.WriteLine("C" + i.ToString() + "D" + callibArrayInt[i].ToString() + "\n\n" + "Sent!");
                    Thread.Sleep(5);
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Please ensure all of your inputted values are numeric, and sensible.\n\n" +
                    "You must fill in duty cycles for at least the first and last vials", "WARNING!", buttons, MessageBoxIcon.Warning);
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

        private void button16_Click(object sender, EventArgs e)
        {
            int vialNum;
            if (int.TryParse(currentVialText.Text, out vialNum)) {
                if (vialNum < totalVials) { vialNum += 1; }
                else { vialNum = 1;  }
                sendToPort("V0");
                currentVialText.Text = vialNum.ToString();
             }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int vialNum;
            if (int.TryParse(currentVialText.Text, out vialNum))
            {
                if (vialNum > 1) { vialNum -= 1; }
                else { vialNum = totalVials; }
                sendToPort("V1");
                currentVialText.Text = vialNum.ToString();
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Calibration CSV Files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clearButton_Click(sender, e);
                    filePath = openFileDialog.FileName;
                    var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            string[] newStrings = line.Split(',');
                            if (!string.IsNullOrWhiteSpace(vialNumBox.Text))
                            {
                                vialNumBox.AppendText("\r\n" + newStrings[0]);
                            }
                            else
                            {
                                vialNumBox.AppendText(newStrings[0]);
                            }
                            if (!string.IsNullOrWhiteSpace(vialDutyBox.Text))
                            {
                                vialDutyBox.AppendText("\r\n" + newStrings[1]);
                            }
                            else
                            {
                                vialDutyBox.AppendText(newStrings[1]);
                            }
                        }
                    }
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string[] lines = convertCallibToString();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Calibration CSV (*.csv)|*.csv|All Files (*.*)|*.*";
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

        private string[] convertCallibToString()
        {
            string[] output = new string[vialNumBox.Lines.Length];
            for (long i = 0; i < vialNumBox.Lines.Length; i++)
            {
                output[i] += vialNumBox.Lines[i] + "," + vialDutyBox.Lines[i];
            }

            return output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            vialNumBox.Text = "";
            vialDutyBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int vialNum;
            int vialDuty;
            if (int.TryParse(vialNumInput.Text, out vialNum) && int.TryParse(vialDutyInput.Text, out vialDuty) && vialNum <= totalVials) {
                if (vialNum < 0){ vialNum *= -1; }
                if (vialDuty < 0) { vialDuty *= -1; }
                //if (vialNumBox.Lines.Contains(vialNum.ToString()))
                //{
                //    int index = vialNum + -1;
                //    vialDutyBox.Lines[index] = vialDuty.ToString();
                //}
                //else
                //{
                    if (!string.IsNullOrWhiteSpace(vialNumBox.Text))
                    {
                        vialNumBox.AppendText("\r\n" + vialNum.ToString());
                    }
                    else
                    {
                        vialNumBox.AppendText(vialNum.ToString());
                    }
                    if (!string.IsNullOrWhiteSpace(vialDutyBox.Text))
                    {
                        vialDutyBox.AppendText("\r\n" + vialDuty.ToString());
                    } 
                    else
                    {
                        vialDutyBox.AppendText(vialDuty.ToString());
                    }
                    
                //}
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            vialNumBox.Lines = vialNumBox.Lines.Take(vialNumBox.Lines.Length - 1).ToArray();
            vialDutyBox.Lines = vialDutyBox.Lines.Take(vialDutyBox.Lines.Length - 1).ToArray();
        }

        private void totalNumVialsButton_Click(object sender, EventArgs e)
        {
            int vialNum;
            if (int.TryParse(totalVialsInput.Text, out vialNum))
            {
                if (vialNum < 0) { vialNum *= -1; }
                totalVials = vialNum;
                Console.WriteLine("Total vials updated to: " +  vialNum);
                sendToPort("T" + totalVials.ToString());
                totalNum.Text = vialNum.ToString();
            }
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            int vialNum;
            if (int.TryParse(textBox1.Text, out vialNum) && vialNum <= totalVials)
            {
                if (vialNum < 0) { vialNum *= -1; }
                vialNum += vialOffset;
                sendToPort("P" + vialNum.ToString());
                currentVialText.Text = vialNum.ToString();
            }
            
        }

        private void dutyCycleButton_Click(object sender, EventArgs e)
        {
            float offset;
            if (float.TryParse(dutyCycleBox.Text, out offset))
            {
                offset = (float) Math.Round(offset, 2);
                if (offset < 0) { offset *= -1; }
                //int intermediate = (int)offset;
                //offset = intermediate / 10000;
                sendToPort("D" + offset.ToString());
                currentOffsetText.Text = offset.ToString();
            }
        }

        private void angleButton_Click(object sender, EventArgs e)
        {
            float angle;
            if (float.TryParse(angleBox.Text, out angle))
            {
                angle = (float)Math.Round(angle, 2);
                if (angle < 0) { angle *= -1; }
                sendToPort("A" + angle.ToString());
                currentVialText.Text = "N/A";
            }
        }

        private void a2bButton_Click(object sender, EventArgs e)
        {
            float a;
            float b;
            if (float.TryParse(aBox.Text, out a) && float.TryParse(bBox.Text, out b))
            {
                a = (float)Math.Round(a, 2);
                b = (float)Math.Round(b, 2);
                if (a < 0) { a *= -1; }
                if (b < 0) { b *= -1; }
                sendToPort("A" + a.ToString());
                Thread.Sleep(3000);
                sendToPort("A" + b.ToString());
            }
        }

        private void velocityButton_Click(object sender, EventArgs e)
        {
            int velocity;
            if (int.TryParse(velocityBox.Text, out velocity))
            {
                if (velocity < 0) { velocity *= -1; }
                sendToPort("Q" + velocity.ToString());
                currentVelocityText.Text = velocity.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(vialOffsetBox.Text, out num))
            {
                if (num < 0) { num *= -1; }
                vialOffset = num;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            goToButton_Click(sender, e);
        }
    }
}
