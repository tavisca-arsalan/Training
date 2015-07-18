using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.WCF.Model;
namespace Tavisca.EmployeeManagement.Translator
{
    public class RemarkModelFactory
    {
        public static IRemarkHandler CreateInstance(string text)
        {
            var remarkHandler = new RemarkModel(text);
            return remarkHandler;
            
        }
    }
}
