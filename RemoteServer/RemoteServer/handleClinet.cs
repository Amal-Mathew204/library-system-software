using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace RemoteServer
{
    //Class to handle each client request separatly
    class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        NetworkStream networkStream;
        public void startClient(TcpClient inClientSocket, string clineNo)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }
        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;
            clientSocket.ReceiveBufferSize = 10025;
            string titleofbook = "";

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                     networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    titleofbook = dataFromClient.Substring(0,dataFromClient.IndexOf("$")) + ".jpg";
                    Console.WriteLine(" >> " + "From client-" + clNo + dataFromClient);

                    rCount = Convert.ToString(requestCount);
                    serverResponse = "Server to clinet(" + clNo + ") " + rCount;
                    sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);

                    








                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }

               try
                {
                    networkStream = clientSocket.GetStream();
                    int blockSize = 10025;
                    byte[] RecData = new byte[blockSize];
                    int RecBytes;

                    string SaveFileName = "D:\\LIbrary Bespoke Software\\" + titleofbook;
                    lock (this)

                    {


                        if (SaveFileName != string.Empty)
                        {
                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
                            while ((RecBytes = networkStream.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
                




            }
        }
    }
}
    

