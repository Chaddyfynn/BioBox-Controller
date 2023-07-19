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

namespace BioBox_Controller
{
    public partial class mainForm : Form
    {
        public SerialPort port;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void sendToPort(string msg)
        {
            port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM5";
            port.Open();
            port.WriteLine(msg);
            port.Close();
        }

        private void timerText_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            sendToPort("c0"); //c0: control 0 - stop
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sendToPort("c1"); //c1: control 1 - start
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            sendToPort("f0"); //f0: function 0 - rotate
        }

        private void vibrateButton_Click(object sender, EventArgs e)
        {
            sendToPort("f1"); //f1: function 1 - vibrate
        }
    }
}
