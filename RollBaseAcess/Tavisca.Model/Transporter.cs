using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;
using Tavisca.Model.Translators;

namespace Tavisca.Model
{
    public static class Transporter
    {
        public static List<Remark> GetRemarksById(string employeeId, string pageNumber)
        {
            string EmployeeServiceUrl = ConfigurationManager.AppSettings["EmployeeServiceUrl"];
            var client = new HttpClient();
            var responseList = client.GetData<List<Remark>>(EmployeeServiceUrl + "remarks/"+employeeId+"/"+pageNumber);
            return responseList;
        }

        public static Dictionary<string, string> GetAllEmployees()
        { 
              Dictionary<string, string> employeeDictionary = new Dictionary<string, string>();
              HttpClient client = new HttpClient();
              string EmployeeServiceUrl = ConfigurationManager.AppSettings["EmployeeServiceUrl"];
              var employeeList = client.GetData<List<Employee>>(EmployeeServiceUrl +"employee");
              foreach (var employeeRecord in employeeList)
              {
                  employeeDictionary.Add(employeeRecord.Id,employeeRecord.FirstName + " " + employeeRecord.LastName);
              }
              return employeeDictionary;
        }

        public static ClientRemark AddRemark(string employeeId, string text)
        {
            Remark remark = new Remark()
            {
                Text = text,
                CreateTimeStamp = DateTime.UtcNow
            };

            string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
            var client = new HttpClient();
            var addedRemark = client.UploadData<Remark, Remark>(EmployeeManagementServiceUrl +"employee/"+employeeId+"/remark",remark);
            return RemarkTranslator.ToClientModel(addedRemark);
        }

    }
}
