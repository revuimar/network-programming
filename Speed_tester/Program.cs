using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.Diagnostics;



namespace Speed_tester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        private static Thread UDPListenerThread;
        private static Thread TCPListenerThread;
        private static Task<int> initialMessage;
        private static Stopwatch UDPStopWatch;
        private static Stopwatch TCPStopWatch;
        private static Stopwatch UDPstatsCalc;
        private static Stopwatch TCPstatsCalc;
        private static UdpClient clientForUDP;
        private static TcpClient clientForTCP;
        private static TcpListener listenerForTCP;
        private static TcpListener TCPInitialListener;
        private static Form1 form;
        public delegate void listenDelegate(Int32 port);
        //public static ChangeNotifier<int> sizeNotifier;
        private static int UDPsize = 0;
        private static int TCPsize = 0;
        private static int totalerrors = 0;
        private static int testingSize = 0;

        public static void stopListeners()
        {
            Console.WriteLine("Stopping Listeners");
            Console.WriteLine("Task status: " + (initialMessage == null).ToString());
            
            if (TCPInitialListener != null)
            {
                TCPInitialListener.Stop();
            }
            if(clientForTCP != null)
            {
                Console.WriteLine("Closing TCP client");
                clientForUDP.Close();
                listenerForTCP.Stop();
            }
            if (clientForUDP != null)
            {
                Console.WriteLine("Closing UDP client");
                clientForUDP.Close();
            }
            if (UDPListenerThread != null)
                UDPListenerThread.Abort();
            if (TCPListenerThread != null)
                TCPListenerThread.Abort();


            clearUI("UDP");
            clearUI("TCP");
            UDPStopWatch.Reset();
            TCPStopWatch.Reset();
            UDPstatsCalc.Reset();
            TCPstatsCalc.Reset();
            UDPsize = 0;
            TCPsize = 0;
            totalerrors = 0;
            testingSize = 0;

            Console.WriteLine("Closing liseners Done");
        }
        
        public async static void startListeners(Int32 port)
        {
            UDPStopWatch = new Stopwatch();
            TCPStopWatch = new Stopwatch();
            UDPstatsCalc = new Stopwatch();
            TCPstatsCalc = new Stopwatch();
            //async await for tcp message with size
            initialMessage = Task<int>.Run(() => recieveInitialMessage(port));
            
            Console.WriteLine("Awaiting task completion");
            int result = await initialMessage;
            initialMessage.Dispose();
            if(result != 0)
            {
                return;
            }
            

            Console.WriteLine("Initial handshake: " + initialMessage.IsCompleted.ToString());
            //listenDelegate listenUDP = new listenDelegate(ListenToUDP);
            //listenDelegate listenTCP = new listenDelegate(ListenToTCP);
            UDPListenerThread = new Thread(() => ListenToUDP(port));//listenUDP.Invoke(port));
            TCPListenerThread = new Thread(() => ListenToTCP(port));
            UDPListenerThread.Start();
            TCPListenerThread.Start();
        }

        private static int recieveInitialMessage(Int32 port)
        {
            
            TCPInitialListener = new TcpListener(port);
            Console.WriteLine("Listening...");
            TCPInitialListener.Start();
            while (true)
            {
                try
                {
                    clientForTCP = TCPInitialListener.AcceptTcpClient();
                    if (clientForTCP.Connected)
                    {
                        break;
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Initial Connection not established");
                    return -1;
                }
                catch (SocketException)
                {
                    Console.WriteLine("Client not found");
                }
            }
            try
            {
                NetworkStream nwStream = clientForTCP.GetStream();
                byte[] buffer = new byte[clientForTCP.ReceiveBufferSize];

                //---read incoming stream---
                int bytesRead = nwStream.Read(buffer, 0, clientForTCP.ReceiveBufferSize);
                string dataReceived = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                testingSize = int.Parse(dataReceived);
                Console.WriteLine("Size set: "+ dataReceived);
                nwStream.Write(buffer, 0, bytesRead);
                clientForTCP.Close();
                TCPInitialListener.Stop();
                Console.WriteLine("Initial message acquired");
            }
            catch (Exception)
            {
                Console.WriteLine("Connection corrupted");
                return -1;
            }
            return 0;
        }
        private static void ListenToTCP(Int32 port)
        {
            listenerForTCP = new TcpListener(port);
            listenerForTCP.Start();
            NetworkStream nwStream = null;
            try
            {
                clientForTCP = listenerForTCP.AcceptTcpClient();
                nwStream = clientForTCP.GetStream();
            }
            catch (SocketException)
            {
                Console.WriteLine("Socket connection refused");
            }
            Console.WriteLine("satrting data acquirement: "+((IPEndPoint)clientForTCP.Client.RemoteEndPoint).Address.ToString());
            bool startFlag = true;
            while (true)
            {
                Byte[] recieve = new Byte[testingSize];
                int bytesRead = 0;
                try
                {
                    bytesRead = nwStream.Read(recieve, 0, testingSize);
                    nwStream.Write(recieve, 0, testingSize);
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("connection died");
                    return;
                }
                if (startFlag && recieve.Length != 0)
                {
                    TCPStopWatch.Start();
                    startFlag = false;
                }
                TCPsize += bytesRead;
                updateUI(recieve, "TCP");
             }
        }
        private static void ListenToUDP(Int32 port)
        {
            clientForUDP = new UdpClient();
            IPEndPoint LocalEndpoint = new IPEndPoint(IPAddress.Any, port);
            clientForUDP.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            clientForUDP.ExclusiveAddressUse = false;
            clientForUDP.Client.Bind(LocalEndpoint);
            IPEndPoint remoteEndpoint = new IPEndPoint(IPAddress.Any, 0);
            string message = String.Empty;
            bool startFlag = true;
            do
            {
                Byte[] recieve = null;
                try
                {
                    recieve = clientForUDP.Receive(ref remoteEndpoint);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Connection closed");
                    break;
                }
                if (startFlag && recieve.Length != 0)
                {
                    UDPStopWatch.Start();
                    startFlag = false;
                }
                UDPsize += recieve.Length;
                updateUI(recieve, "UDP");
            } while (true);
        }
        private static void clearUI(string protocol)
        {
            form.updateTextBox(protocol, Form1.fieldType.dataSize,"0");
            form.updateTextBox(protocol, Form1.fieldType.transTime, "0");
            form.updateTextBox(protocol, Form1.fieldType.totalDataSize, "0");
            form.updateTextBox(protocol, Form1.fieldType.loss, "0");
            form.updateTextBox(protocol, Form1.fieldType.errorRate, "0");
            form.updateTextBox(protocol, Form1.fieldType.transSpeed, "0");
        }
        private static void updateUI(Byte[] data, string protocol)
        {
            //if (form.IsAccessible)
            //{
            UDPstatsCalc.Reset();
            TCPstatsCalc.Reset();
            UDPstatsCalc.Start();
            TCPstatsCalc.Start();
            if (protocol == "UDP")
            {

                form.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    if (data.Length != 0)
                    {
                        form.updateTextBox(protocol, Form1.fieldType.dataSize, testingSize.ToString());
                        form.updateTextBox(protocol, Form1.fieldType.transTime, UDPStopWatch.Elapsed.Seconds.ToString());
                    }
                    else
                    {
                        UDPStopWatch.Stop();
                    }
                    if (UDPStopWatch.Elapsed.Seconds != 0) form.updateTextBox(protocol, Form1.fieldType.transSpeed, (UDPsize / 1000 / UDPStopWatch.Elapsed.Seconds).ToString());
                    form.updateTextBox(protocol, Form1.fieldType.totalDataSize, (UDPsize / 1000).ToString());
                    form.updateTextBox(protocol, Form1.fieldType.loss, totalerrors.ToString());
                    form.updateTextBox(protocol, Form1.fieldType.errorRate, streamAccuracy(data, testingSize).ToString());
                });
                UDPstatsCalc.Stop();
                form.Invoke((MethodInvoker)delegate
                {
                    form.updateTextBox(protocol, Form1.fieldType.statsTime, UDPstatsCalc.ElapsedMilliseconds.ToString());
                });
            }
            else
            {
                form.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    if (data.Length != 0)
                    {
                        form.updateTextBox(protocol, Form1.fieldType.dataSize, testingSize.ToString());
                        form.updateTextBox(protocol, Form1.fieldType.transTime, TCPStopWatch.Elapsed.Seconds.ToString());
                    }
                    else
                    {
                        TCPStopWatch.Stop();
                    }
                    if (TCPStopWatch.Elapsed.Seconds != 0) form.updateTextBox(protocol, Form1.fieldType.transSpeed, (TCPsize / 1000 / TCPStopWatch.Elapsed.Seconds).ToString());
                    form.updateTextBox(protocol, Form1.fieldType.totalDataSize, (TCPsize / 1000).ToString());
                    form.updateTextBox(protocol, Form1.fieldType.loss, totalerrors.ToString());
                    form.updateTextBox(protocol, Form1.fieldType.errorRate, streamAccuracy(data, testingSize).ToString());
                });
                TCPstatsCalc.Stop();
                form.Invoke((MethodInvoker)delegate
                {
                    form.updateTextBox(protocol, Form1.fieldType.statsTime, TCPstatsCalc.ElapsedMilliseconds.ToString());
                });
            }
            //}
        }
        private static Byte[] byteGenerator(int byteSize)
        {
            Byte[] b = new Byte[byteSize];
            for (int i = 0; i < byteSize; i++)
                b[i] = 0x20;
            return b;
        }
        private static float streamAccuracy(Byte[] recieved,int targetsize)
        {
            int errors = 0;
            int rec_size = recieved.Length;
            Byte[] target = byteGenerator(targetsize);
            for (int i = 0; i < targetsize; i++)
            {
                if(i> rec_size)
                {
                    errors += 1;
                }
                else
                {
                    if((target[i] != recieved[i]))
                    {
                        errors += 1;
                    }
                }
            }
            totalerrors += errors;
            if (targetsize == 0) return -1;
            return (errors) / targetsize * 100;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }
    }
}
