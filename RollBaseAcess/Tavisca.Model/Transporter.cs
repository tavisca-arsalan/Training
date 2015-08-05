using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;
using Tavisca.Model.Translators;
using Tavisca.Model.EmployeeService;

namespace Tavisca.Model
{
    public static class Transporter
    {
        public static PagenatedRemarkListResponse GetRemarksById(string employeeId, string pageNumber)
        {
            string EmployeeServiceUrl = ConfigurationManager.AppSettings["EmployeeServiceUrl"];
            var client = new HttpClient();
            var responseList = client.GetData<PagenatedRemarkListResponse>(EmployeeServiceUrl + "remarks/" + employeeId + "/" + pageNumber);     
            return responseList;
        }

        public static Dictionary<string, string> GetAllEmployees()
        { 
              Dictionary<string, string> employeeDictionary = new Dictionary<string, string>();
              HttpClient client = new HttpClient();
              string EmployeeServiceUrl = ConfigurationManager.AppSettings["EmployeeServiceUrl"];
              var employeeListResponse = client.GetData<EmployeeListResponse>(EmployeeServiceUrl +"employee");
            
              foreach (var employeeRecord in employeeListResponse.EmployeeList.OrderBy(employee=>employee.FirstName))
              {
                  employeeDictionary.Add(employeeRecord.Id,employeeRecord.FirstName + " " + employeeRecord.LastName);
              }
              return employeeDictionary;
        }

        public static ClientRemark AddRemark(string employeeId, string text)
        {
            Tavisca.Model.EmployeeManagementService.Remark remark = new Tavisca.Model.EmployeeManagementService.Remark()
            {
                Text = text,
                CreateTimeStamp = DateTime.UtcNow
            };

            string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
            var client = new HttpClient();
            var addedRemark = client.UploadData<Tavisca.Model.EmployeeManagementService.Remark, RemarkResponse>(EmployeeManagementServiceUrl +"employee/"+employeeId+"/remark",remark);
            if (addedRemark.Status.StatusCode.Equals("200"))
            {
                return RemarkTranslator.ToClientModel(addedRemark.Remark);
            }
            else
                return null;
        }

    }
}
