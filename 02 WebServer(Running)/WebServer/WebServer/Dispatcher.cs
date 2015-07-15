using System;
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
      //  private Socket _clientSocket=null; 
        private bool _isRunning = true;
        private static HandlerFactory _handlerFactory = new HandlerFactory();
        public Dispatcher()
        { 
        }
        public void Dispatch(Socket clientSocket)
        {
            var requestParser = new RequestParser();
            string requestString = DecodeRequest(clientSocket);
            if (string.IsNullOrWhiteSpace(requestString) == false)
            {
                requestParser.Parse(requestString);
                Console.WriteLine(requestParser.HttpUrl);
                int dotIndex = requestParser.HttpUrl.LastIndexOf('.') + 1;
                if (dotIndex > 0)
                {  
                    var requestHandler = _handlerFactory.CreateHandler(requestParser.HttpUrl,clientSocket, ConfigurationManager.AppSettings["Path"]);

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
                    HomePageHandler homePageHandler = new HomePageHandler(clientSocket, ConfigurationManager.AppSettings["Path"]);
                    homePageHandler.DoGet(requestParser.HttpUrl);
                }  
            }
         //   StopClientSocket(_clientSocket);  //closes the connection
        }

        internal void Start()
        {
            while (this._isRunning)
            {
                Socket socket;
                if (Application.RequestQueue.TryDequeue(out socket) == false) continue;
                Task.Factory.StartNew(() =>
                {
                    this.Dispatch(socket);
                });
            }
        }

        internal void Stop()
        {
            this._isRunning = false;
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
