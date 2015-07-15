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
        
        private TcpListener _tcpListener;
        private bool _running = false;
       

        public Listener(string host,int port)
        {
            _tcpListener = new TcpListener(IPAddress.Parse(host), port);
        }

        public void Listen()
        {
            _running = true;
            _tcpListener.Start();
            Console.WriteLine("Waiting for conection...");
            Debug.WriteLine("Waiting for conection...");
            while (_running)
            {
                this._tcpListener.Start();
                var socket = this._tcpListener.AcceptSocket();
                if (socket.Connected == false) continue;
                // Implement queue properly
                Application.RequestQueue.Enqueue(socket);
            }
            
        }
              
        public void Stop()
        {
            this._tcpListener.Stop();
        }

     }
}
