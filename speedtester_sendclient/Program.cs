using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace speedtester_sendclient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        private static List<Thread> UDPTransmission;
        private static List<Thread> TCPTransmission;
        private static Task<int> initial;
        private static bool cancelTask;
        private static UdpClient client;
        private static List<string> current_fulladdress;
        private static CancellationTokenSource source;
        private static CancellationToken token;


        public async static Task<bool> startTransmission(int size,List<string> fulladdress,bool isNagle)
        {
            source = new CancellationTokenSource();
            token = source.Token;
            current_fulladdress = fulladdress;
            String[] firstAddress = fulladdress[0].Split(':');
            initial = Task<int>.Run(() => sendInitialMessage(size, Int32.Parse(firstAddress[1]), firstAddress[0]),token);
            int result = 0;
            try
            {
                result = await initial;
            }
            catch(OperationCanceledException)
            {
                Console.WriteLine("Request canceled");
                return false;
            }
            finally
            {
                source.Dispose();
            }
            if(result != 0)
            {
                initial.Dispose();
                return false;
            }
            Console.WriteLine("Server acnowledged!");

            source = new CancellationTokenSource();
            token = source.Token;

            foreach (var item in fulladdress)
            {
                String[] addressAndPort = item.Split(':');
                UDPTransmission.Add(new Thread(() => sendUDPTransfer(size, Int32.Parse(addressAndPort[1]), addressAndPort[0],token)));
                TCPTransmission.Add(new Thread(() => sendTCPTransfer(size, Int32.Parse(addressAndPort[1]), addressAndPort[0],isNagle,token)));
                UDPTransmission.Last().Start();
                TCPTransmission.Last().Start();
            }
            return true;
        }
        public static void stoppedHandshake()
        {
            source.Cancel();
        }
        public static void stopTransmission(string protocol)
        {
            
            int index = 0;
            
            foreach (var item in ((protocol == "UDP")?UDPTransmission:TCPTransmission))
            {
                System.Console.WriteLine(current_fulladdress[index].ToString() + ((protocol == "UDP")?"UDP":"TCP") + " transmittion closed");
                try
                {
                    item.Abort();
                }
                catch(ThreadAbortException e)
                {
                    System.Console.Write(" Thread msg:" + e.HResult.ToString());
                }
                index++;
            }
            if (protocol == "UDP")
                UDPTransmission.Clear();
            else
                TCPTransmission.Clear();
        }

        private static Byte[] byteGenerator(int byteSize)
        {
            Byte[] b = new Byte[byteSize];
            for (int i = 0; i < byteSize; i++)
                b[i] = 0x20;
            return b;
        }
        public static int sendInitialMessage(int size, Int32 port, string address)
        {
            
            TcpClient client = null;
            string textToSend = size.ToString();
            Console.WriteLine("connection setup");
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    try
                    {
                        token.ThrowIfCancellationRequested();
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("Operation Canceled");
                    }

                    return -1;
                }
                try
                {
                    client = new TcpClient(address, port);
                    if (client.Connected)
                    {
                        Console.WriteLine("connection established");
                        break;
                    }
                }
                catch (SocketException)
                {
                    Console.WriteLine("Connection not established");
                }
                
            }
            try
            {
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = System.Text.ASCIIEncoding.ASCII.GetBytes(textToSend);
                //---send the text---
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                //int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                //Console.WriteLine("Received : " + System.Text.Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Initial connection closed: " + e.Message);
            }
            client.Close();
            return 0;
        }
            public static void sendUDPTransfer(int size, Int32 port, string address, CancellationToken _token)
        {
            client = new UdpClient();
            Byte[] msg = byteGenerator(size);
            IPEndPoint ipRemoteEndpoint = new IPEndPoint(IPAddress.Parse(address), port);
            System.Console.WriteLine(address + ":" + port.ToString() + " UDP: " + size.ToString() + " bytes" + " transfer UP");

            while (true)
            {
                if (_token.IsCancellationRequested)
                {
                    client.Close();
                    break;
                }
                client.Send(msg, msg.Length, ipRemoteEndpoint);
                Thread.Sleep(10);
            }
        }
        public static void sendTCPTransfer(int size, Int32 port, string address, bool isNagle, CancellationToken _token)
        {
            //---data to send to the server---
            Byte[] msg = byteGenerator(size);
            NetworkStream nwStream = null;
            TcpClient client = null;
            //---create a TCPClient object at the IP and port no.---
            try
            {
                client = new TcpClient(address, port);
                client.Client.NoDelay = isNagle;
                nwStream = client.GetStream();
            }
            catch (SocketException)
            {
                Console.WriteLine("connection not established for: "+ ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                return;
            }
            System.Console.WriteLine(address + ":" + port.ToString() + " TCP: " + size.ToString() + " bytes" + " transfer UP");

            while (true)
            {
                if (_token.IsCancellationRequested)
                {
                    nwStream.Close();
                    client.Close();
                    break;
                }
                try
                {
                    nwStream.Write(msg, 0, size);
                    Thread.Sleep(10);
                }
                catch (System.IO.IOException)
                {
                    System.Console.WriteLine("connection died");
                    return;
                }
            }
            
        }
        [STAThread]
        static void Main()
        {
            UDPTransmission = new List<Thread>();
            TCPTransmission = new List<Thread>();
            cancelTask = false;

            source = new CancellationTokenSource();
            token = source.Token;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
