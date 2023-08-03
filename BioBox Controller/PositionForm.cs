using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
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
    }
}
