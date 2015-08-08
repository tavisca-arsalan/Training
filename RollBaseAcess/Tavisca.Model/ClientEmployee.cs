using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;
using Tavisca.Model.Translators;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tavisca.Model
{
    public class ClientEmployee
    {
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
         [Required]
        public string FirstName { get; set; }
         [Required]
        public string LastName { get; set; }
         [Required]
        public string Email { get; set; }
         [Required]
        public string Phone { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Password { get; set; }

        public List<ClientRemark> Remarks { get; set; }

        public ClientEmployee CreateEmployee() 
        {
            Employee employee = EmployeeTranslator.ToDataContract(this);
            string EmployeeManagementServiceUrl = ConfigurationManager.AppSettings["EmployeeManagementServiceUrl"];
            var client = new HttpClient();
            var createdEmployee = client.UploadData<Employee, EmployeeResponse>(EmployeeManagementServiceUrl + "employee", employee);
            if (createdEmployee.Status.StatusCode.Equals("200"))
            {
                return EmployeeTranslator.ToClientModel(createdEmployee.Employee);
            }
            else
                throw new Exception("Failed to add the employee remark due to: " + createdEmployee.Status.Message);
        }
    }
}
