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
using TCP_Lib;

namespace TcpClient
{
    public partial class Form1 : Form
    {
        public static Form1 FormDialog;


        /*TCP 서버
         */
        private int LocalPort = 13000;
        private static string HostName = Dns.GetHostName();
        private string strIPaddress = Dns.GetHostEntry(HostName).AddressList[1].ToString();
        private TcpServer Server;



        /*
         * TCP 클라이언트
         */
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
        private string dataSoilHumi;

        public Form1()
        {
            InitializeComponent();
            FormDialog = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * 
             */

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




            /*
             *  시리얼이 연결 됬을 때
             */
            if (connect.PassSerial != null)
            {
                if (connect.PassSerial.IsOpen)
                {
                    comPort = connect.PassSerial;
                    PassSerial = comPort;
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceved);
                    lblSerial.Text = "On";
                }

            }
            else
            {
                lblSerial.Text = "Off";
            }


            /**
             *  TCP 연결 됬을 때
             */

            //Client = new System.Net.Sockets.TcpClient(); //
            //Client.Connect(IPAddress.Parse("192.168.0.3"), 13000); //
            //Writer = new StreamWriter(Client.GetStream()); //

            tcpConnect = connect.PassTCP;

            if(tcpConnect == true)
            {
                Writer = connect.PassWriter;
                lblServer.Text = "On";
            }
            else
            {
                lblServer.Text = "Off";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void TCPmsgReceive(string msg)
        {

            /*
                NODE MCU 에서 Tcp서버로 송신 되었을 때 
             */
            if (msg.Substring(0, 1) == "@")
            {
                dataSoilHumi = msg.Substring(1);
                lblSoil.Text = dataSoilHumi;
            }

        }
    }
}
