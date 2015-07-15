using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace WebServer
{
    class TextRequestHandler:IProcessor
    {
        public RegistryKey RegistryKey = Registry.ClassesRoot;
        public Socket ClientSocket = null;
        private string _contentPath;
        public FileHandler FileHandler;

        public TextRequestHandler(Socket clientSocket, string contentPath)
        {
            _contentPath = contentPath;
            ClientSocket = clientSocket;
            FileHandler = new FileHandler(_contentPath);
        }
        public void DoGet(string requestedFile)         // Check parameter value
        {
           
                if (FileHandler.FileExists(requestedFile))    //If yes check existence of the file
                    ResponseSender.SendResponse(ClientSocket, FileHandler.ReadFile(requestedFile), "200 Ok", GetTypeOfFile(RegistryKey, (_contentPath + requestedFile)));
                else
                    SendErrorResponce(ClientSocket); 
        }

        public void DoPost()
        {
            throw new NotImplementedException();
        }

         public static string GetTypeOfFile(RegistryKey registryKey, string fileName)
        {
            RegistryKey fileClass = registryKey.OpenSubKey(Path.GetExtension(fileName));
            string type = "";
            try
            {
                type= fileClass.GetValue("Content Type").ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return type;
        }
        
        private void SendErrorResponce(Socket clientSocket)
        {
            byte[] emptyByteArray = new byte[0];
            ResponseSender.SendResponse(clientSocket,emptyByteArray, "404 Not Found", "text/html");
        }


       

    }
}


