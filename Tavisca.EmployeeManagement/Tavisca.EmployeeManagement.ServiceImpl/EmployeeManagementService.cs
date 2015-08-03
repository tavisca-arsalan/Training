using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.EmployeeManagement.ServiceContract;
using Tavisca.EmployeeManagement.Interface;
using Tavisca.EmployeeManagement.Translator;
using Tavisca.EmployeeManagement.EnterpriseLibrary;
using Tavisca.EmployeeManagement.DataContract;

namespace Tavisca.EmployeeManagement.ServiceImpl
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        IEmployeeManagementManager _manager;

        public EmployeeManagementService(IEmployeeManagementManager manager)
        {
            _manager = manager;
        }

       

        public DataContract.Employee Create(DataContract.Employee employee)
        {
            try
            {
                var result = _manager.Create(employee.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                throw newEx;
            }
        }

        public DataContract.Remark AddRemark(string employeeId, DataContract.Remark remark)
        {
            try
            {
                var result = _manager.AddRemark(employeeId, remark.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                throw newEx;
            }
        }

        public DataContract.Employee CheckCredentials(DataContract.Credentials credentials)
        {
            var result = _manager.CheckCredentials(credentials.EmailId,credentials.Password);
            if (result == null) return null;
            return result.ToDataContract();
        }

        public string ModifyCredentials(CredentialModifier newCredentials)
        {
            int status = _manager.ModifyCredentials(newCredentials.EmailId, newCredentials.OldPassword, newCredentials.NewPassword);
           
            return status.ToString();
        }



       
    }
}
