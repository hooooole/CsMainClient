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
    public partial class Form1 : Form
    {
        private int LocalPort = 13000;
        private IPAddress LocalAddress = IPAddress.Parse("192.168.0.20");
        private string HostName = Dns.GetHostName();
        private bool tcpConnect = false;
        public static bool PassTCP { get; set; }

        private System.Net.Sockets.TcpClient Client;
        private Thread ReceiveThread;
        private bool Connected = false;

        private NetworkStream stream;
        private StreamReader Reader;
        private StreamWriter Writer;

        private delegate void setTextDelegate(string getStrig);

        /**
         * 시리얼 포트
         * 
         */

        SerialPort comPort = null;
        public static SerialPort PassSerial { get; set; }


        private string dataTemp;
        private string dataHumi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (Writer != null) Writer.Close();
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /**
         * 시리얼포트 , TCP 통신 연결 버튼
         */

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Form connectFrom = new connect();
            //connectFrom.StartPosition = FormStartPosition.Manual;
            //connectFrom.Location = new Point(600, 300);
            connectFrom.BringToFront();
            connectFrom.ShowDialog();


            if (connect.PassSerial != null)
            {
                if (connect.PassSerial.IsOpen)
                {
                    comPort = connect.PassSerial;
                    PassSerial = comPort;
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceved);
                }

            }
            tcpConnect = connect.PassTCP;
            PassTCP = tcpConnect;
            if(tcpConnect == true)
            {
                Writer = new StreamWriter(connect.PassClient.GetStream());
            }


        }

        private void DataReceved(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = comPort.ReadTo("\n");
            this.BeginInvoke(new setTextDelegate(SerailReceved), new object[] { rxd });
        }


        private void SerailReceved(string inString)
        {
            string Head = inString.Substring(0, 1);
            string Data = inString.Substring(1);

            if (Head == "@")
            {
                string[] PasingData = Data.Split(',');
                dataTemp = PasingData[0];
                dataHumi = PasingData[1];
                lblTmp.Text = dataTemp;
                lblHmd.Text = dataHumi;

                if (tcpConnect)
                {

                    SendToServer();
                }
            }
        }
        private void SendToServer()
        {
            string msg = "@"+"nano," + dataTemp + "," + dataHumi;
            Writer.WriteLine(msg);
            Writer.Flush();
        }
        private void btnState_Click(object sender, EventArgs e)
        {
            Form videoform = new video();
            videoform.StartPosition = FormStartPosition.Manual;
            videoform.Location = new Point(700, 180);
            videoform.BringToFront();
            videoform.ShowDialog();
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            // After Complete to Deep Learning
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTmp_Click(object sender, EventArgs e)
        {

        }

        private void lblConnectState_Click(object sender, EventArgs e)
        {
            // on & off
            if (lblConnectState.Text == "Off")
            {
                comPort = new SerialPort();
                comPort.PortName = lblConnectState.Text;
                comPort.BaudRate = Convert.ToInt32(lblConnectState.Text);
                comPort.DataBits = 8;
                comPort.Parity = Parity.None;
                comPort.StopBits = StopBits.One;
                comPort.Handshake = Handshake.None;
                comPort.Open();
                comPort.DiscardInBuffer();
                PassSerial = comPort;
                lblConnectState.Text = "On";
            }
            else
            {
                PassSerial = null;
                comPort.Close();
                lblConnectState.Text = "Off";
            }
        }
    }
}
