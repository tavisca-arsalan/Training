using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    internal class Application
    {
        public static IQueue RequestQueue { get; private set; }
        static Application()
        {
            RequestQueue = new InProcQueue();
        }
      
    }
}
