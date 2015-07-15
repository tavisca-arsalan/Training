using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
   
        internal class Application
        {
            static Application()
            {
                RequestQueue = new InProcQueue();
            }
            public static IQueue RequestQueue { get; private set; }
        }
 }
