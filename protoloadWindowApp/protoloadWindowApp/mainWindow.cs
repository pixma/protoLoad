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

namespace protoloadWindowApp
{
    public partial class mainWindow : Form
    {
        private bool isConnected;
        private SerialPort _serialPort = new SerialPort();
        /// End of transmition byte in this case EOT (ASCII 4). 
        /// </summary> 
        private byte _terminator = 0x4;
        /// <summary> 
        /// Holds data received until we get a terminator. 
        /// </summary> 
        private string tString = string.Empty;

        delegate  void doDumpVerbose( string value);

        public mainWindow()
        {
            InitializeComponent();
            isConnected = false;
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            #region window_init
            this.Text = "protoload";
            portButton.Text = "Connect";
            comboBox_bitsps.SelectedIndex = comboBox_databits.SelectedIndex = comboBox_flowControl.SelectedIndex = comboBox_parity.SelectedIndex = comboBox_stopBit.SelectedIndex = 0;

            if (checkBoxVerbosMode.Checked)
            {
                dumpBox.Enabled = true;
            }
            else
            {
                dumpBox.Enabled = false;
            }

            //com port list
            string[] ports = SerialPort.GetPortNames();
            comportComboBox.Items.Add("COM PORT");

            foreach (String port in ports)
            {
                comportComboBox.Items.Add(port);
            }
            comportComboBox.SelectedIndex = 0;

            toolStripStatusLabel_ComPort.Text = "Com port";
            toolStripStatusLabel_ComPort_Status.Text = "Not Connected";
            toolStripStatusLabel_Info.Text = "Please set things up first then connect.";
            #endregion
        }

        private void portButton_Click(object sender, EventArgs e)
        {
            if (comportComboBox.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "Please select a COM port first.";
                return;
            }
            else if (comboBox_bitsps.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "please select a valid Baud Rate.";
                return;

            }
            else if (comboBox_databits.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "Please select a valid Data Bits.";
                return;
            }
            else if (comboBox_flowControl.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "Please select a valid Flow Control";
                return;
            }
            else if (comboBox_parity.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "Please select a valid Parity.";
                return;
            }
            else if (comboBox_stopBit.SelectedIndex == 0)
            {
                toolStripStatusLabel_Info.Text = "Please select a valid Stop bit.";
                return;
            }
            //
            //if every thing is fine then try to connect to com port.
            try
            {
                _serialPort.BaudRate = getComPortBaudRate();
                _serialPort.DataBits = getDataBits();
                _serialPort.Handshake = Handshake.None;
                _serialPort.Parity = getParity();
                _serialPort.PortName = comportComboBox.SelectedItem.ToString();
                _serialPort.StopBits = getStopBits();

                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    //means now COM port is connected and opened.
                    portButton.Text = "Diconnect";
                    portButton.Click -= this.portButton_Click;
                    portButton.Click += this.portButton_Disconnect;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);

                    toolStripStatusLabel_ComPort.Text = comportComboBox.SelectedText;
                    toolStripStatusLabel_ComPort_Status.Text = "Connected";
                    toolStripStatusLabel_Info.Text = "Connected Successfully.";

                    comportComboBox.Enabled = false;
                    comboBox_bitsps.Enabled = false;
                    comboBox_databits.Enabled = false;
                    comboBox_flowControl.Enabled = false;
                    comboBox_parity.Enabled = false;
                    comboBox_stopBit.Enabled = false;

                }
            }
            catch (Exception exep)
            {
                toolStripStatusLabel_Info.Text = exep.Message.ToString();
            }
        }

        private int getDataBits()
        {
            switch (comboBox_databits.SelectedIndex)
            {
                case 1:
                    return 7;
                    break;
                case 2:
                    return 8;
                    break;
            }
            return 0;
        }

        private int getComPortBaudRate()
        {
            /*
             * Baud Rate
                300
                600
                1200
                1800
                2400
                4800
                7200
                9600
                14400
                19200
                38400
                57600
                115200
                230400
                460800
                921600

            */

            switch (comboBox_bitsps.SelectedIndex)
            {
                case 0:
                    return 0;
                    break;
                case 1:
                    return 300;
                    break;
                case 2:
                    return 600;
                    break;
                case 3:
                    return 1200;
                    break;
                case 4:
                    return 1800;
                    break;
                case 5:
                    return 2400;
                    break;
                case 6:
                    return 4800;
                    break;
                case 7:
                    return 7200;
                    break;
                case 8:
                    return 9600;
                    break;
                case 9:
                    return 14400;
                    break;
                case 10:
                    return 19200;
                    break;
                case 11:
                    return 38400;
                    break;
                case 12:
                    return 57600;
                    break;
                case 13:
                    return 115200;
                    break;
                case 14:
                    return 230400;
                    break;
                case 15:
                    return 460800;
                    break;
                case 16:
                    return 921600;
                    break;
            }

            return 0;
        }

        private void portButton_Disconnect(object sender, EventArgs e)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    portButton.Text = "Connect";

                    comportComboBox.Enabled = true;
                    comboBox_bitsps.Enabled = true;
                    comboBox_databits.Enabled = true;
                    comboBox_flowControl.Enabled = true;
                    comboBox_parity.Enabled = true;
                    comboBox_stopBit.Enabled = true;

                    toolStripStatusLabel_ComPort.Text = comportComboBox.SelectedItem.ToString();
                    toolStripStatusLabel_ComPort_Status.Text = "Disconnected";
                    toolStripStatusLabel_Info.Text = "State: Not Connected...";

                    portButton.Click -= this.portButton_Disconnect;
                    portButton.Click += this.portButton_Click;
                }
            }
            catch (Exception execp)
            {
                toolStripStatusLabel_Info.Text = execp.Message;
            }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Initialize a buffer to hold the received data 
            string buffer;

            buffer = _serialPort.ReadLine();
            Invoke(new doDumpVerbose(dumpVerboseUpdate),buffer);
        }

        private void dumpVerboseUpdate(string value)
        {
            if (checkBoxVerbosMode.Checked)
            {
                dumpBox.AppendText(value);
                dumpBox.AppendText(Environment.NewLine);
            }
            loadFigure.Text = value;
        }

        private StopBits getStopBits()
        {
            if (comboBox_stopBit.SelectedText == "1")
            {
                return StopBits.One;
            }
            else if (comboBox_stopBit.SelectedText == "2")
            {
                return StopBits.Two;
            }
            else
            {
                return StopBits.One;
            }
            return StopBits.One;
        }

        private Parity getParity()
        {
            /**
             *
             * Even
                Odd
                None
                Mark
                Space 
             * 
             * */

            if (comboBox_parity.SelectedText == "Even")
            {
                return Parity.Even;
            }
            else if (comboBox_parity.SelectedText == "Odd")
            {
                return Parity.Odd;
            }
            else if (comboBox_parity.SelectedText == "None")
            {
                return Parity.None;
            }
            else if (comboBox_parity.SelectedText == "Mark")
            {
                return Parity.Mark;
            }
            else if (comboBox_parity.SelectedText == "Space")
            {
                return Parity.Space;
            }
            else
            {
                return Parity.None;
            }

            return Parity.None;
        }

        private void buttonDumWIndowClear_Click(object sender, EventArgs e)
        {
            dumpBox.Text = "";
        }
    }
}
