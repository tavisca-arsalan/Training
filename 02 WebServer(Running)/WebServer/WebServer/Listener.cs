 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Diagnostics;


namespace WebServer
{
    class Listener
    {
        
        private TcpListener _listener;
        private bool _running = false;
       

        public Listener(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
        }

        public void Run()
        {
            _running = true;
            _listener.Start();
            Console.WriteLine("Waiting for conection...");
            Debug.WriteLine("Waiting for conection...");
            while (_running)
            {
                   // this._listener.Start();                    
                    var socket = this._listener.AcceptSocket();
                    if (socket.Connected == false) continue;
                    Application.RequestQueue.Enqueue(socket);                
            }
        }
        public void Stop()
        {
            this._listener.Stop();
        }

    }
}
