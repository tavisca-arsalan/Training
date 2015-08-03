using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Model.EmployeeManagementService;

namespace Tavisca.Model.Translators
{
    public static class EmployeeTranslator
    {
        public static Employee ToDataContract(ClientEmployee clientEmployee)
        {
            Employee employee = new Employee()
            {
                Title = clientEmployee.Title,
                FirstName = clientEmployee.FirstName,
                LastName = clientEmployee.LastName,
                Email = clientEmployee.Email,
                JoiningDate = clientEmployee.JoiningDate,
                Phone = clientEmployee.Phone,
                Remarks = clientEmployee.Remarks == null ? null : clientEmployee.Remarks.Select(remark => RemarkTranslator.ToDataContract(remark)).ToArray()
            };
            return employee;
        }

        public static ClientEmployee ToClientModel(Employee employee)
        {
            ClientEmployee clientEmployee = new ClientEmployee()
            {
                Id = employee.Id,
                Title = employee.Title,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                JoiningDate = employee.JoiningDate,
                Phone = employee.Phone,
                Remarks = employee.Remarks == null ? null : employee.Remarks.Select(remark => RemarkTranslator.ToClientModel(remark)).ToList()
            };
            return clientEmployee;
        }

    }
}
