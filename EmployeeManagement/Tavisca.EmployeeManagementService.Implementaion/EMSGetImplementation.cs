using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.EmployeeManagement.DataContract;
using Tavisca.EmployeeManagement.ServiceContract;
using Tavisca.EmployeeManagement.Translator;
using Tavisca.WCF.Model;

namespace Tavisca.EmployeeManagementService.Implementaion
{
    class EMSGetImplementation:IEmployeeService
    {
        public Employee Get(string id)
        {
            EmployeeModel employeeModel = EmployeeModel.GetEmployeeById(id);
            return Translator.TranslateToEmployee(employeeModel);
        }

        public List<Employee> GetAll()
        {
            
            List<EmployeeModel> employeeModelList = EmployeeModel.GetAllEmployees();
           
             return Translator.TranslateToEmployee(employeeModelList);

        }
        }
    }

