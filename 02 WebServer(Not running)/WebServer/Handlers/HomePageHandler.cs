using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class HomePageHandler //:IProcessor
    {

        public RegistryKey RegistryKey = Registry.ClassesRoot;
        public Socket ClientSocket = null;
        private string _contentPath;
        public FileHandler FileHandler;

        public HomePageHandler (Socket clientSocket, string contentPath)
        {
            _contentPath = contentPath;
            ClientSocket = clientSocket;
            FileHandler = new FileHandler(_contentPath);
        }
        public void DoGet(string requestedFile)         // Check parameter value
        {
            if (FileHandler.FileExists("\\index.htm"))
                ResponseSender.SendResponse(ClientSocket, FileHandler.ReadFile("\\index.htm"), "200 Ok", "text/html");
            else if (FileHandler.FileExists("\\index.html"))
                ResponseSender.SendResponse(ClientSocket, FileHandler.ReadFile("\\index.html"), "200 Ok", "text/html");
            else
                SendErrorResponce(ClientSocket);
               
        }
      

        public void DoPost()
        {
            throw new NotImplementedException();
        }

        
        private void SendErrorResponce(Socket clientSocket)
        {
            byte[] emptyByteArray = new byte[0];
            ResponseSender.SendResponse(clientSocket,emptyByteArray, "404 Not Found", "text/html");
        }
    }
}
