using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace TcpClient
{
    public partial class Form1 : Form
    {
        private int LocalPort = 13000;
        private IPAddress LocalAddress = IPAddress.Parse("192.168.0.20");
        private string HostName = Dns.GetHostName();

        private System.Net.Sockets.TcpClient Client;
        private Thread ReceiveThread;
        private bool Connected = false;

        private NetworkStream stream;
        private StreamReader Reader;
        private StreamWriter Writer;

        private delegate void setTextDelegate(string getStrig);

        SerialPort comPort = new SerialPort();

        private string dataTemp;
        private string dataHumi;

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceved);
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

            if(Head == "@")
            {
                string[] PasingData = Data.Split(',');
                dataTemp = PasingData[0];
                dataHumi = PasingData[1];
                lblTmp.Text = dataTemp;
                lblHmd.Text = dataHumi;

                if (Connected) SendToServer();
            }
        }

        private void SendToServer()
        {
            string msg = "@" + HostName + "," + dataTemp + "," + dataHumi;
            Writer.WriteLine(msg);
            Writer.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TCP Client -" + HostName;
            txtUser.Text = HostName;

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

        }

        private void btnTcpConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTcpConnect.Text == "Connect")
                {
                    Client = new System.Net.Sockets.TcpClient();

                    Client.Connect(IPAddress.Parse(txtIPaddress.Text), LocalPort);

                    Connected = true;
                    stream = Client.GetStream();
                    Reader = new StreamReader(stream);
                    Writer = new StreamWriter(stream);

                    ReceiveThread = new Thread(new ThreadStart(TCP_Receive));
                    ReceiveThread.Start();

                    lblStatus.Text = "Connect to Server!";
                    btnTcpConnect.Text = "Close";
                }
                else
                {
                    Connected = false;
                    if (ReceiveThread != null) ReceiveThread.Abort();
                    if (Reader != null) Reader.Close();
                    if (Writer != null) Writer.Close();
                    if (Client != null) Client.Close();

                    lblStatus.Text = "Closed to Server!";
                    btnTcpConnect.Text = "Connect";
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "TCP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TCP_Receive()
        {
            try
            {
                while (Connected)
                {
                    Thread.Sleep(1);

                    if (stream.CanRead)
                    {
                        string strReceived = Reader.ReadLine();

                        if(strReceived.Length > 0)
                        {
                            strReceived = "Receive : " + strReceived;
                            this.BeginInvoke(new setTextDelegate(TCPmsgReceive), new object[] { strReceived });
                        }
                    }
                }
            }catch(Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
                Connected = false;
                if (ReceiveThread != null) ReceiveThread.Abort();
                if (Reader != null) Reader.Close();
                if (Writer != null) Writer.Close();
                if (Client != null) Client.Close();

                btnTcpConnect.Text = "Connect";
            }
        }

        private void TCPmsgReceive(string msg)
        {
            lstRxMsg.Items.Add(DateTime.Now.ToString("HH:mm:ss") + msg);
            if (lstRxMsg.Items.Count > 10) lstRxMsg.Items.RemoveAt(0);
            lstRxMsg.SelectedIndex = lstRxMsg.Items.Count - 1;  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (ReceiveThread != null) ReceiveThread.Abort();
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (Client != null) Client.Close();

        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            if(btnSerial.Text == "Connect")
            {
                comPort.PortName = cmbSerialPort.Text;
                comPort.BaudRate = Convert.ToInt32(cmbBoardRate.Text);
                comPort.DataBits = 8;
                comPort.Parity = Parity.None;
                comPort.StopBits = StopBits.One;
                comPort.Handshake = Handshake.None;
                comPort.Open();
                comPort.DiscardInBuffer();
                btnSerial.Text = "Close";
            }
            else
            {
                comPort.Close();
                btnSerial.Text = "Connect";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataTemp = (rnd.Next(100,250)/10.0).ToString();
            dataHumi = rnd.Next(30, 60).ToString();

            lblTmp.Text = dataTemp;
            lblHmd.Text = dataHumi;

            if (Connected) SendToServer();
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

        private void lstRxMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Accessing to server

            try {
                if (btnConnect.Text == "Connect")
                {
                    LocalAddress = IPAddress.Parse(txtIPaddress.Text);

                    //Client = new TcpClient();
                    Client = new System.Net.Sockets.TcpClient();
                    Client.Connect(LocalAddress, LocalPort);
                    Connected = true;
                    stream = Client.GetStream();
                    Reader = new StreamReader(stream);
                    Writer = new StreamWriter(stream);


                    
                }
            } catch(SocketException ex) {

            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            // Check state of plant
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            // Diagnost plant disease
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*
            Connected = false;
            if (ReceiveThread != null) ReceiveThread.Abort();
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (Client != null) Client.Close();
            */
        }

        private void lblTmp_Click(object sender, EventArgs e)
        {

        }
    }
}
