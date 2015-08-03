using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;
using Tavisca.Model.Translators;
using System.Configuration;

namespace Tavisca.Model
{
    public class ClientEmployee
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Password { get; set; }

        public List<ClientRemark> Remarks { get; set; }

        public ClientEmployee CreateEmployee() 
        {
            Employee employee = EmployeeTranslator.ToDataContract(this);
            string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
            var client = new HttpClient();
            var createdEmployee = client.UploadData<Employee, Employee>(EmployeeManagementServiceUrl + "employee", employee);
            return EmployeeTranslator.ToClientModel(createdEmployee);
        }
    }
}
