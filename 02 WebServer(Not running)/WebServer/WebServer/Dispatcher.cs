using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Dispatcher
    {
        private bool _isRunning = true;

        private static Dictionary<string, Type> _handlerMapping = new Dictionary<string, Type>();
        static Dispatcher()
        {
            var type = typeof(IProcessor);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass);

            types.ToList().ForEach(handlerType =>
            {
                var requestHandlerInstance = Activator.CreateInstance(handlerType) as IProcessor;
                if (string.IsNullOrWhiteSpace(requestHandlerInstance.SupportedTypes)) throw new ArgumentException("Invalid handler registered");
                requestHandlerInstance.SupportedTypes.Split(',').ToList().ForEach(fileType =>
                {
                    Console.WriteLine("Filetype: "+ fileType);
                    _handlerMapping[fileType.ToLower()] = handlerType;
                    Console.WriteLine("Handler registered.");
                });
            });
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

        //..........edit the code below..........
        
        #region Private Helper Methods
        private void Dispatch(Socket clientSocket)
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
                    var requestHandler = this.ResolveHandler(requestParser.HttpUrl);

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
                 //   HomePageHandler homePageHandler = new HomePageHandler(_clientSocket, ConfigurationManager.AppSettings["Path"]);
                   // homePageHandler.DoGet(requestParser.HttpUrl);
                }  
            }
            // Implement its alternative:-----
            //StopClientSocket();  //closes the connection
        }
        /*
        public void StopClientSocket()
        {
            if (_clientSocket != null)
                _clientSocket.Close();
        }*/

        private string DecodeRequest(Socket clientSocket)
        {
            Encoding charEncoder = Encoding.UTF8;
            var receivedBufferlen = 0;
            var buffer = new byte[10240];
            try
            {
                receivedBufferlen =clientSocket.Receive(buffer);
            }
            catch (Exception)
            {
                Console.ReadLine();
            }
            return charEncoder.GetString(buffer, 0, receivedBufferlen);
        }

        private IProcessor ResolveHandler(string url)
        {
            string extension = url.Substring(url.LastIndexOf('.')+1);
            if (_handlerMapping.ContainsKey(extension) == false) throw new Exception("Handler not found: Extension - " + extension);

            return Activator.CreateInstance(_handlerMapping[extension]) as IProcessor;
        }
        #endregion
    }
}
