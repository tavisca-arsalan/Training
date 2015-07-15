using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Server
    {
        private Listener _listner;
        private Dispatcher _dispatcher;

        public Server(string host, int port)
        {
            this._listner = new Listener(port);
            this._dispatcher = new Dispatcher();

        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
            {
                _dispatcher.Start();
            });
            Task.Factory.StartNew(() =>
            {
                _listner.Run();
            });
        }

        public void Stop()
        {
            _listner.Stop();
            _dispatcher.Stop();
        }

    }
}
