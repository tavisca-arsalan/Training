using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.EmployeeManagement.Interface;
using Newtonsoft.Json;
using Tavisca.EmployeeManagement.ErrorSpace;
using System.Data.SqlClient;
using Tavisca.EmployeeManagement.EnterpriseLibrary;

namespace Tavisca.EmployeeManagement.FileStorage
{
    public class CacheEmployeeStorage : IEmployeeStorage
    {
        public CacheEmployeeStorage(ICacheManager manager)
        {
            _innerStorage = new EmployeeStorage();
            _cacheManager = manager;
        }

        IEmployeeStorage _innerStorage;
        ICacheManager _cacheManager;

        readonly string KEYFORMAT = "emp.{0}";
        readonly string CACHEMANAGER = "employee";

        public Model.Employee Save(Model.Employee employee)
        {
            var result = _innerStorage.Save(employee);
            _cacheManager.Add(string.Format(KEYFORMAT, result.Id), result, CACHEMANAGER);
            return result;
        }

        public Model.Employee Get(string employeeId)
        {
            Model.Employee result;
            result = _cacheManager.Get(string.Format(KEYFORMAT, employeeId), CACHEMANAGER) as Model.Employee;
            if (result == null)
            {
                result = _innerStorage.Get(employeeId);
                _cacheManager.Add(string.Format(KEYFORMAT, employeeId), result, CACHEMANAGER);
            }
            return result;
        }

        public List<Model.Employee> GetAll()
        {
            return _innerStorage.GetAll();
        }

        // <<<<<<<<<<<<Dummy code>>>>>>>>>>>>>
        public Model.Remark SaveRemark(string employeeId, Model.Remark remark)
        {
           // throw new NotImplementedException();
            try{
                SqlConnection connection = new SqlConnection("Data Source=Training9;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=test123!@#");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Remarks values(@RemarkId,@EmpId,@Text,@CreateTimeStamp )", connection);
                SqlParameter p1 = new SqlParameter("RemarkId", Guid.NewGuid().ToString());
                SqlParameter p2 = new SqlParameter("EmpId", employeeId);
                SqlParameter p3 = new SqlParameter("Text",remark.Text);
                SqlParameter p4 = new SqlParameter("CreateTimeStamp", remark.CreateTimeStamp.ToString());
               
               
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
             
                cmd.ExecuteNonQuery();
                connection.Close();
                return remark;

            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("data.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }
    }
}
