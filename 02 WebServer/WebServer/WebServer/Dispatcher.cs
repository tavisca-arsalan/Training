﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;

namespace WebServer
{
    class Dispatcher
    {
        private Socket _clientSocket=null; 
        private static HandlerFactory _handlerFactory = new HandlerFactory();
        public Dispatcher(Socket clientSocket)
        {
            _clientSocket = clientSocket; 
        }
        public void HandleClient()
        {
            var requestParser = new RequestParser();
            string requestString = DecodeRequest(_clientSocket);
            if (string.IsNullOrWhiteSpace(requestString) == false)
            {
                requestParser.Parse(requestString);
                Console.WriteLine(requestParser.HttpUrl);
                int dotIndex = requestParser.HttpUrl.LastIndexOf('.') + 1;
                if (dotIndex > 0)
                {  
                    var requestHandler = _handlerFactory.CreateHandler(requestParser.HttpUrl,_clientSocket, ConfigurationManager.AppSettings["Path"]);

                    if (requestParser.HttpMethod.Equals("get", StringComparison.InvariantCultureIgnoreCase))
                    {
                        requestHandler.DoGet(requestParser.HttpUrl);
                    }
                    else
                    {
                        Console.WriteLine("unimplemented methode");
                        Console.ReadLine();
                    }
                }
               else   //find default file as index .htm of index.html
                {
                    HomePageHandler homePageHandler = new HomePageHandler(_clientSocket, ConfigurationManager.AppSettings["Path"]);
                    homePageHandler.DoGet(requestParser.HttpUrl);
                }  
            }
            StopClientSocket(_clientSocket);  //closes the connection
        }

        public void StopClientSocket(Socket clientSocket)
        {
            if (clientSocket != null)
                clientSocket.Close();
        }

        private string DecodeRequest(Socket clientSocket)
        {
            Encoding charEncoder = Encoding.UTF8;
            var receivedBufferlen = 0;
            var buffer = new byte[10240];
            try
            {
                receivedBufferlen = clientSocket.Receive(buffer);
            }
            catch (Exception)
            {
                Console.ReadLine();
            }
            return charEncoder.GetString(buffer, 0, receivedBufferlen);
        }   
        
    }
}
