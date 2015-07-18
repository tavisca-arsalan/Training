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
    public class EMSPostImplementation:IEmployeeManagementService
    {
       public Employee Create(Employee employee)
        {
            EmployeeModel employeeModel = Translator.EmployeeModelGenerator(employee);
            string id = employeeModel.GenerateId();
            employeeModel.Id = id;
            EmployeeModel.InsertEmployeeIntoFile(employeeModel);
            return employee;
        }

        public Remark AddRemark(string employeeId, Remark remark)
        {
            RemarkModel remarkModel = Translator.RemarkModelGenerator(remark);
            string timeStamp = remarkModel.GenerateUtcTime();
            remarkModel.UtcTime = timeStamp;
            RemarkModel.InsertRemarkIntoFile(remarkModel, employeeId);
            return remark;
        }

    }
}
