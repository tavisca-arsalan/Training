using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web; 
using Tavisca.EmployeeManagement.DataContract;

namespace Tavisca.EmployeeManagement.ServiceContract
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [WebInvoke(Method = "GET", UriTemplate = "/get_record/{id}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Employee Get(string id);

        [WebInvoke(Method = "GET", UriTemplate = "/get_record_all", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Employee> GetAll();
    }
}
