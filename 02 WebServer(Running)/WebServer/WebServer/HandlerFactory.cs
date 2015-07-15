using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;
namespace WebServer
{
    class HandlerFactory
    {
        private static List<string> _knownExtensions;
        static HandlerFactory()
        {
            _knownExtensions = ConfigurationManager.AppSettings["known-extensions"].Split(',').ToList();
        }
        // This function was originally a virtual function
        public IProcessor CreateHandler(string url,Socket clientSocket, string contentPath)
        {
            IProcessor requestProcessor = null;
            string extension = GetExtensionFromUrl(url);
            
            if (_knownExtensions.Contains(extension))
            {
                switch (extension)
                {

                    case "html":
                    case "htm":                       
                    case "css":
                    case "js":
                    case "txt":
                        requestProcessor = new TextRequestHandler(clientSocket, contentPath);
                        break;
                    default :
                        requestProcessor= new NotFoundErrorHandler(clientSocket);
                        break;
                }
            }
            else 
            {
                requestProcessor = new UnsupportedMediaTypeErrorHandler(clientSocket);
            }
            return requestProcessor;
        }

        private string GetExtensionFromUrl(string url)
        {
            return url.Substring(url.LastIndexOf('.')+1);
        }
    }
}
