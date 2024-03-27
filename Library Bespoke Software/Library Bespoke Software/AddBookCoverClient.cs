using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
namespace Login_Interface
{
    class AddBookCoverClient
    {
       protected string tbserver = "10.207.71.1";
      //protected string tbserver = "192.168.0.147";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream;
        
        public AddBookCoverClient()
        {
            clientSocket.Connect(tbserver, 8888);
        }

        public bool AddBookCover(string Filename, string Title)
        {
            bool x = true;
            try
            {


                NetworkStream serverStream = clientSocket.GetStream();


                string Titlebook = Title + "$";
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Titlebook);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();


                byte[] inStream = new byte[10025];
                clientSocket.ReceiveBufferSize = 10025;
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);


                serverStream = clientSocket.GetStream();

                //reading the file
                Stream fileStream = File.OpenRead(Filename);
                byte[] fileBuffer = new byte[fileStream.Length];
                fileStream.Read(fileBuffer, 0, (int)fileStream.Length);

                serverStream.Write(fileBuffer, 0, fileBuffer.GetLength(0));

                serverStream.Flush();

                
            }
            catch(Exception ex)
            {
                x = false;
            }

            return x;

        }
    }
}
