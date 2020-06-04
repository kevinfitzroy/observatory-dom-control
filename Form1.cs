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
namespace Observatory
{
    public partial class Form1 : Form
    {

        GateControl gc;
        List<Button> buttonArry = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            this.Title.Parent = this.pictureBox1;
            capControlInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                serialDrop.Items.Add(port);
                CapSerialDrop.Items.Add(port);
            }
            if (ports.Length > 0)
            {
                serialDrop.SelectedIndex = 0;
                CapSerialDrop.SelectedIndex = 0;
            }
            this.Disposed += Form1_Disposed;

            //init button status
            OpenSerialPort.Enabled = true;
            CloseSerialPort.Enabled = false;
            disableAllButton();

            gc = new GateControl(this, () =>
            {
                OpenSerialPort.Enabled = false;
                CloseSerialPort.Enabled = true;
                enableAllButton();
            }, () =>
            {
                OpenSerialPort.Enabled = true;
                CloseSerialPort.Enabled = false;
                disableAllButton();
            }, Log,
            disableAllButton,
            enableAllButton
           );
            buttonArry.Add(OpenGate);
            buttonArry.Add(CloseGate);
            buttonArry.Add(OpenLeftGate);
            buttonArry.Add(CloseLeftGate);
            buttonArry.Add(OpenRightGate);
            buttonArry.Add(CloseRightGate);
            buttonArry.Add(OpenLeftMinimal);
            buttonArry.Add(OpenRightMinimal);
            buttonArry.Add(CloseLeftMinimal);
            buttonArry.Add(CloseRightMinimal);
            buttonArry.Add(OpenLeftAnyDegree);
            buttonArry.Add(OpenRightAnyDegree);
            buttonArry.Add(CloseLeftAnyDrgree);
            buttonArry.Add(CloseRightAnyDegree);

            OpenAnyDropBox.SelectedIndex = 1;
            CloseAnyDropBox.SelectedIndex = 1;

            logBox.Enabled = false;
            Log("please connect serial port");

        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            if (capsp.IsOpen)
                capsp.Close();

            gc.Dispose();
        }

        private void OpenSerialPort_Click(object sender, EventArgs e)
        {
            string portName = serialDrop.Text;
            if (portName == "")
            {
                Log("none serial port selected");
                return;
            }

            gc.connect(portName);

        }
        private void CloseSerialPort_Click(object sender, EventArgs e)
        {
            gc.disconnect();
        }


        private void CloseGate_Click(object sender, EventArgs e)
        {
            gc.CloseGate();
        }

        private void OpenGate_Click(object sender, EventArgs e)
        {
            gc.OpenGate();
        }

        private void CloseLeftGate_Click(object sender, EventArgs e)
        {
            gc.CloseLeftGate();
        }


        private void CloseRightGate_Click(object sender, EventArgs e)
        {
            gc.CloseRightGate();
        }

        private void OpenLeftGate_Click(object sender, EventArgs e)
        {
            gc.OpenLeftGate();
        }

        private void OpenRightGate_Click(object sender, EventArgs e)
        {
            gc.OpenRightGate();
        }

        private void OpenLeftMinimal_Click(object sender, EventArgs e)
        {
            gc.OpenLeftMinimal();
        }

        private void OpenRightMinimal_Click(object sender, EventArgs e)
        {
            gc.OpenRightMinimal();
        }

        private void CloseLeftMinimal_Click(object sender, EventArgs e)
        {
            gc.CloseLeftMinimal();
        }

        private void CloseRightMinimal_Click(object sender, EventArgs e)
        {
            gc.CloseRightMinimal();
        }

        private void OpenLeftAnyDegree_Click(object sender, EventArgs e)
        {
            gc.OpenLeftAny(readOpenAnyValue());
        }

        private void OpenRightAnyDegree_Click(object sender, EventArgs e)
        {
            gc.OpenRightAny(readOpenAnyValue());

        }

        private void CloseLeftAnyDrgree_Click(object sender, EventArgs e)
        {
            gc.CloseLeftAny(readCloseAnyValue());
        }

        private void CloseRightAnyDegree_Click(object sender, EventArgs e)
        {
            gc.CloseRightAny(readCloseAnyValue());
        }

        float readOpenAnyValue()
        {
            string text = OpenAnyDropBox.Text;
            return float.Parse(text);

        }
        float readCloseAnyValue()
        {
            return float.Parse(CloseAnyDropBox.Text);
        }

        void Log(string s)
        {
            logBox.AppendText(DateTime.Now.ToString());
            logBox.AppendText("\t");
            logBox.AppendText(s);
            logBox.AppendText("\r\n");
        }



        void enableAllButton()
        {
            foreach (Button b in buttonArry)
            {
                b.Enabled = true;
            }
        }
        void disableAllButton()
        {
            foreach (Button b in buttonArry)
            {
                b.Enabled = false;
            }

        }

        /*cap control*/

        private SerialPort capsp = new SerialPort();
        static int CapBaudRate = 115200;

        static int CapDataBit = 8;
        static Parity parity = Parity.None;
        static StopBits stopBit = StopBits.One;

        private void capControlInit()
        {
            capsp.BaudRate = CapBaudRate;
            capsp.DataBits = CapDataBit;
            capsp.Parity = parity;
            capsp.StopBits = stopBit;
        }
        private bool connectCapControl()
        {
            string portName = CapSerialDrop.Text;
            if (portName == "")
            {
                Log("Cap Serial Port Not Selected");
                return false;
            }
            capsp.PortName = portName;
            try
            {

                capsp.Open();
            }
            catch (Exception e)
            {
                Log(e.Message);
            }
            return true;

        }

        private void capAreaButtonsChange()
        {
            CapFullOpenButton.Enabled = !CapFullOpenButton.Enabled;
            CapHalfOpenButton.Enabled = !CapHalfOpenButton.Enabled;
            CapCloseButton.Enabled = !CapCloseButton.Enabled;
            CapAnyOpenButton.Enabled = !CapAnyOpenButton.Enabled;
        }

        private void CapConnectButton_Click(object sender, EventArgs e)
        {
            if (capsp.IsOpen)
            {
                capsp.Close();
                capAreaButtonsChange();
                CapConnectButton.Text = "Connect";
            }
            else if (connectCapControl())
            {
                capAreaButtonsChange();
                CapConnectButton.Text = "Disable";
            }
        }

        private void CapFullOpenButton_Click(object sender, EventArgs e)
        {
            SendCapControlComand("180");
        }

        private void CapHalfOpenButton_Click(object sender, EventArgs e)
        {
            SendCapControlComand("90");
        }

        private void CapCloseButton_Click(object sender, EventArgs e)
        {
            SendCapControlComand("0");
        }

        private void CapAnyOpenButton_Click(object sender, EventArgs e)
        {
            string degree_s = capOpenDegreeBox.Text;
            int degree = 0;
            try
            {
                degree = int.Parse(degree_s);
            }
            catch (FormatException fe)
            {
                Log("Cap Control Degree Input Error");
                return;
            }

            if (degree >= 0 || degree <= 180)
            {
                SendCapControlComand(degree_s);
            }

        }

        private void SendCapControlComand(string command)
        {
            Log("Cap Control: Move " + command);
            try
            {
                capsp.Write(command);
            }
            catch (Exception e)
            {
                Log(e.Message);
            }
        }
    }
}
