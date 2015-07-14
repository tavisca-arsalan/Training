﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class NotFoundErrorHandler:IProcessor
    {
        public RegistryKey RegistryKey = Registry.ClassesRoot;
        private Socket _clientSocket = null;
        private Encoding _charEncoder = Encoding.UTF8;
       
        
        public NotFoundErrorHandler(Socket clientSocket)
        {
            _clientSocket = clientSocket;
        }
       

        public void DoGet(string uri)
        {
            byte[] emptyByteArray = new byte[0];
            ResponseSender.SendResponse(_clientSocket, emptyByteArray, "404 Not Found", "text/html");
        }

        public void DoPost()
        {
            throw new NotImplementedException();
        }
    }
}
