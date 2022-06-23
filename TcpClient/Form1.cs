using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        /*
        * 진단 결과 Hash Table
        */
        Hashtable results = new Hashtable();

        public Form1()
        {
            InitializeComponent();
            FormDialog = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * 폼이 켜질 때 NodeMCU 서버 on
             */

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd ddd");

            IPHostEntry HostDNSEntry = System.Net.Dns.GetHostEntry(HostName);
            IPAddress[] allIPsOfThisHost = null;
            IPAddress ipv4Ret = null;
            allIPsOfThisHost = HostDNSEntry.AddressList;

            for (int idx = allIPsOfThisHost.Length - 1; idx > 0; idx--) {
                //if an IPV4 address is found, return the address
                if (allIPsOfThisHost[idx].AddressFamily == AddressFamily.InterNetwork)
                {
                    ipv4Ret = allIPsOfThisHost[idx];
                    break;
                }
            }
            strIPaddress = ipv4Ret.ToString();

            Server = new TcpServer(13000);
            Server.IPaddress = strIPaddress;
            Server.MaxConnections = 2;
            Server.Start();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (Writer != null) Writer.Close();
        }


        private void label12_Click(object sender, EventArgs e)
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
             *  시리얼 연결 됐을 때
             */

            if (connect.PassSerial != null) {
                if (connect.PassSerial.IsOpen)
                {
                    comPort = connect.PassSerial;
                    PassSerial = comPort;
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceved);
                    lblSerial.Text = "On";
                }
            } else {
                lblSerial.Text = "Off";
            }

            /**
             *  TCP 연결 됐을 때
             */

            tcpConnect = connect.PassTCP;

            if(tcpConnect == true)
            {
                Writer = connect.PassWriter;
                lblServer.Text = "On";
                PassTCP = true;
            } else {
                lblServer.Text = "Off";
                PassTCP = false;
            }
        }

        private void DataReceved(object sender, SerialDataReceivedEventArgs e)
        {
            string rxd = comPort.ReadTo("\n");
            this.BeginInvoke(new setTextDelegate(SerailReceved), new object[] { rxd });
        }

        private void SerailReceved(string inString)
        {
            /*
             * 시리얼 송신 부
             */
            
        }

        private void SendToServer()
        {
            string msg = "@"+ dataTemp + "," + dataHumi + "," + dataSoilHumi;
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

        /**
         *  !!! 실행되는 PC에서 경로 설정 해주어야 함 !!!
         */
        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            try
            {
                comPort.Write("1000");
            }
            catch (Exception ex)
            {

            }
            

            //경로 설정
            string bat = @"C:\Users\User\test.bat";
            var psi = new ProcessStartInfo();
            psi.CreateNoWindow = true;
            psi.FileName = @"cmd.exe";
            psi.Verb = "runas";
            psi.Arguments = "/C " + bat;

            try
            {
                var process = new Process();
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
            catch (Exception)
            {

                Console.WriteLine("exception ocurred.");
            }


            //경로 설정
            string dirPath = @"C:\Project\deeplearning\yolov5\yolov5\results";
            string dirName = "";
            if (Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);
                foreach (var item in di.GetDirectories())
                {
                    dirName = item.Name;
                    Console.WriteLine(dirName);
                }

            }
            Console.WriteLine(dirName);
            string path = dirPath + @"\" + dirName;
            Console.WriteLine(path);
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                string[] parsed = file.Split('_')[0].Split('\\');
                if (!results.ContainsKey(parsed[parsed.Length - 1]))
                {
                    results.Add(parsed[parsed.Length-1], true);
                }
            }
            foreach (DictionaryEntry de in results)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
            ShowResult.PassHash = results;


            Form resultForm = new ShowResult();
            resultForm.StartPosition = FormStartPosition.Manual;
            resultForm.Location = new Point(700, 180);
            resultForm.BringToFront();
            resultForm.ShowDialog();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void TCPmsgReceive(string msg)
        {

            /*
                NODE MCU 에서 Tcp서버로 송신 되었을 때 
             */
            string Head = msg.Substring(0, 1);
            string Data = msg.Substring(1);

            if (Head == "@")
            {
                string[] PasingData = Data.Split(',');
                dataTemp = PasingData[0];
                dataHumi = PasingData[1];
                dataSoilHumi = PasingData[2];
                lblTmp.Text = dataTemp;
                lblHmd.Text = dataHumi;
                lblSoil.Text = dataSoilHumi;

            }
        }
        /**
         * 서버 PC로 센서 값 송신
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tcpConnect)
            {
                SendToServer();
            }
        }
        /**
         * 아두이노로 토양습도 송신
         */
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                comPort.Write("20");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
