using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
namespace Login_Interface
{
    class LibrarySoftwareUserServerClient
    {
        protected string tbserver = "192.168.0.147";//"10.207.71.1";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream;

        public LibrarySoftwareUserServerClient(string user)
        {
                clientSocket.Connect(tbserver, 7777);

       


                NetworkStream serverStream = clientSocket.GetStream();


                user = user + "$";
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(user);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();


        }
    }
}
