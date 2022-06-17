using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using TcpClient;

namespace TCP_Lib
{
    public class ConnectionState
    {
        internal Socket _conn;
        internal TcpServer _server;
        internal DateTime _incoming;
        
        internal byte[] _buffer;

        public EndPoint RemoteEndPoint
        {
            get { return _conn.RemoteEndPoint; }
        }

        public int AvailableData
        {
            get { return _conn.Available; }
        }

        public bool Connected
        {
            get { return _conn.Connected; }
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                if (_conn.Available > 0)
                    return _conn.Receive(buffer, offset, count, SocketFlags.None);
                else return 0;
            }
            catch
            {
                return 0;
            }
        }

        public bool Write(byte[] buffer, int offset, int count)
        {
            try
            {
                _conn.Send(buffer, offset, count, SocketFlags.None);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void EndConnection()
        {
            if (_conn != null && _conn.Connected)
            {
                _conn.Shutdown(SocketShutdown.Both);
                _conn.Close();
            }
            _server.DropConnection(this);
        }
    }

    public class TcpServer
    {
        private string _IPaddress;
        private int _port;
        private Socket _listener;
        
        private ArrayList _connections;
        private ArrayList _ClientStatus;
        private int _maxConnections = 3;

        private string _receivedStr;

        private AsyncCallback ConnectionReady;
        private WaitCallback AcceptConnection;
        private AsyncCallback ReceivedDataReady;
        
        private delegate void SetTextDelegate(string getString);

        public TcpServer( int port)
        {
            _port = port;
            _listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _connections = new ArrayList();
            _ClientStatus = new ArrayList();

            ConnectionReady = new AsyncCallback(ConnectionReady_Handler);
            AcceptConnection = new WaitCallback(AcceptConnection_Handler);
            ReceivedDataReady = new AsyncCallback(ReceivedDataReady_Handler);
        }

        public bool Start()
        {
            try
            {
                _listener.Bind(new IPEndPoint(IPAddress.Parse(_IPaddress), _port));
                _listener.Listen(100);
                _listener.BeginAccept(ConnectionReady, null);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ConnectionReady_Handler(IAsyncResult asyncResult)
        {
            lock (this)
            {
                if (_listener == null) return;
                Socket conn = _listener.EndAccept(asyncResult);
                if (_connections.Count >= _maxConnections)
                {
                    string msg = "$busy";
                    conn.Send(Encoding.UTF8.GetBytes(msg), 0, msg.Length, SocketFlags.None);
                    conn.Shutdown(SocketShutdown.Both);
                    conn.Close();
                }
                else
                {
                    ConnectionState state = new ConnectionState();
                    state._conn = conn;
                    state._server = this;
                    state._incoming = DateTime.Now;
                    state._buffer = new byte[4];
                    _connections.Add(state);

                    Update_Connection();

                    ThreadPool.QueueUserWorkItem(AcceptConnection, state);
                }
                _listener.BeginAccept(ConnectionReady, null);
            }
        }

        private void Update_Connection()
        {
            _ClientStatus.Clear();

            foreach (object obj in _connections)
            {
                ConnectionState state = obj as ConnectionState;
                Socket conn=state._conn;
                IPEndPoint ip_point = (IPEndPoint)conn.RemoteEndPoint;
                string status = ip_point.Address.ToString() + "," + ip_point.Port.ToString() + ","+ state._incoming.ToString("yyyy-MM-dd HH:mm:ss");
                _ClientStatus.Add(status);
            }
        }

        private void AcceptConnection_Handler(object ConnState)
        {
            ConnectionState state = ConnState as ConnectionState;
            try
            {
                _receivedStr = "";
                if (!state.Write(Encoding.UTF8.GetBytes("$Accept\n"), 0, 8)) state.EndConnection();
            }
            catch
            {
                //
            }

            if (state._conn.Connected) state._conn.BeginReceive(state._buffer, 0, 0, SocketFlags.None, ReceivedDataReady, state);
        }
        
        private void ReceivedDataReady_Handler(IAsyncResult asyncResult)
        {
            try
            {
                ConnectionState state = asyncResult.AsyncState as ConnectionState;
                state._conn.EndReceive(asyncResult);

                if (state._conn.Available == 0)
                {
                    DropConnection(state);
                }
                else
                {
                    try 
                    {
                        byte[] buffer = new byte[1024];
                        while (state.AvailableData > 0)
                        {
                            int readBytes = state.Read(buffer, 0, 1024);
                            if (readBytes > 0)
                            {
                                _receivedStr += Encoding.UTF8.GetString(buffer, 0, readBytes);
                                if (_receivedStr.IndexOf("\n") >= 0)
                                {
                                    //-----------------------------------------------------------------------
                                    string rxmsg = DateTime.Now.ToString("HH:mm:ss") + "," + _receivedStr;
                                    Form1.FormDialog.BeginInvoke(new SetTextDelegate(Form1.FormDialog.TCPmsgReceive), new object[] { rxmsg });
                                    
                                    state.Write(Encoding.UTF8.GetBytes(_receivedStr), 0, _receivedStr.Length);
                                    _receivedStr = "";
                                }
                            }
                            else
                            {
                                state.EndConnection();
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "LocalServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (state._conn.Connected) state._conn.BeginReceive(state._buffer, 0, 0, SocketFlags.None, ReceivedDataReady, state);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"LocalServer",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Stop()
        {
            try
            {
                lock (this)
                {
                    _listener.Close();
                    _listener = null;

                    foreach (object obj in _connections)
                    {
                        ConnectionState state = obj as ConnectionState;
                        try
                        {
                            DropConnection(state);
                        }
                        catch
                        {
                            //some error
                        }
                        state._conn.Shutdown(SocketShutdown.Both);
                        state._conn.Close();
                    }
                    _connections.Clear();
                    Update_Connection();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LocalServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void DropConnection(ConnectionState state)
        {
            lock (this)
            {
                state._conn.Shutdown(SocketShutdown.Both);
                state._conn.Close();


                if (_connections.Contains(state))
                {
                    _connections.Remove(state);
                    Update_Connection();
                }
            }
        }

        public int MaxConnections
        {
            get { return _maxConnections;  }
            set { _maxConnections = value;  }
        }

        public ArrayList ClientStatus
        {
            get { return _ClientStatus; }
        }

        public string IPaddress
        {
            get { return _IPaddress; }
            set { _IPaddress = value; }
        }
    }
}
