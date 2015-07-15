using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    public interface IProcessor
    {
        string SupportedTypes { get; }
        void DoGet(string uri);
        void DoPost();
    }
}
