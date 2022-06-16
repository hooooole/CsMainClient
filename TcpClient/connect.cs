using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class connect : Form
    {
        private int LocalPort = 13000;

        private System.Net.Sockets.TcpClient Client;
        private bool Connected = false;
        public static bool PassTCP { get; set; }

        public static System.Net.Sockets.TcpClient PassClient { get; set; }
        

        private NetworkStream stream;
        private StreamReader Reader;

        private delegate void setTextDelegate(string getStrig);


        /*
         * 시리얼 포트 객체
         */
        SerialPort comPort = null;
        public static SerialPort PassSerial { get; set; }

        public connect()
        {
            InitializeComponent();
        }

        private void connect_Load(object sender, EventArgs e)
        {
            Connected = Form1.PassTCP;
            comPort = Form1.PassSerial;

            cmbSerialPort.Items.Clear();
            var portName = System.IO.Ports.SerialPort.GetPortNames();
            cmbSerialPort.Items.AddRange(portName);
            cmbSerialPort.SelectedIndex = cmbSerialPort.Items.Count - 1;

            cmbBoardRate.Items.Clear();
            cmbBoardRate.Items.Add("9600");
            cmbBoardRate.Items.Add("19200");
            cmbBoardRate.Items.Add("57600");
            cmbBoardRate.Items.Add("115200");
            cmbBoardRate.SelectedIndex = 0;
            
            //connect.Location = new Point();

            if (comPort != null)
            {
                if (comPort.IsOpen)
                {
                    btnSerial.Text = "Close";
                }
                else
                {
                    btnSerial.Text = "Connect";
                }
            }

            if (Connected)
            {
                btnTcpConnect.Text = "Close";
            }
            else
            {
                btnTcpConnect.Text = "Connect";
            }

        }

        /*
         * 시리얼 포트 연결
         */

        private void btnSerial_Click(object sender, EventArgs e)
        {
            if (btnSerial.Text == "Connect")
            {
                comPort = new SerialPort();
                comPort.PortName = cmbSerialPort.Text;
                comPort.BaudRate = Convert.ToInt32(cmbBoardRate.Text);
                comPort.DataBits = 8;
                comPort.Parity = Parity.None;
                comPort.StopBits = StopBits.One;
                comPort.Handshake = Handshake.None;
                comPort.Open();
                comPort.DiscardInBuffer();
                PassSerial = comPort;
                btnSerial.Text = "Close";
            }
            else
            {
                PassSerial = null;
                comPort.Close();
                btnSerial.Text = "Connect";
            }
        }

        /*
         * TCP/IP 서버 연결
         */

        private void btnTcpConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Connected == false)
                {
                    Client = new System.Net.Sockets.TcpClient();
                    PassClient = Client;
                    Client.Connect(IPAddress.Parse(txtIPaddress.Text), LocalPort);
                    Connected = true;
                    PassTCP = Connected;
                    stream = Client.GetStream();
                    Reader = new StreamReader(stream);
                    
                    btnTcpConnect.Text = "Close";
                }
                else
                {
                    Connected = false;
                    if (Reader != null) Reader.Close();
                    if (Client != null) Client.Close();

                    btnTcpConnect.Text = "Connect";
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "TCP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connect_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
