using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.WCF.DAL;
using Microsoft.JScript;
using Newtonsoft.Json;


namespace Tavisca.WCF.Model
{
    public class EmployeeModel:IEmployeeHandler
    {
        public EmployeeModel(string title,string firstName, string lastName, string email)
        {
            this.Id = "";
            this.Title = title;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Remark ="";
        }
        public string Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

       
        public string Email
        {
            get;
            set;
        }

        public String Remark
        {
            get;
            set;
        }
        
        public string GenerateId()
        {
            string UniqueId = string.Format(@"{0}", Guid.NewGuid());
            return UniqueId;
        }

        public static void InsertEmployeeIntoFile(EmployeeModel employee)
        {

            var jsonString = JsonConvert.SerializeObject(employee);

            FileSystem file = new FileSystem();
            file.SaveEmployee(jsonString, employee.Id);
        }

            /*
                        Dictionary<string, string> employeeDictionary = new Dictionary<string, string>();
                        employeeDictionary.Add("Id",this.Id);
                        employeeDictionary.Add("Title",this.Title);
                        employeeDictionary.Add("FistName",this.FirstName);
                        employeeDictionary.Add("LastName",this.LastName); 
             * string str = "{\"Arg1\":\"Arg1Value\",\"Arg2\":\"Arg2Value\"}";
            JavaScriptSerializer serializer1 = new JavaScriptSerializer();
            object obje = serializer1.Deserialize(str, obj1.GetType());
                        employeeDictionary.Add("Email",this.Email);ng
                        var save = new FileSystem();
                        save.SaveEmployee(employeeDictionary);
             * */

        
        public static EmployeeModel GetEmployeeById(string id)
        {
            FileSystem file = new FileSystem();

            EmployeeModel employeeModel = JsonConvert.DeserializeObject<EmployeeModel>(file.RetrieveById(id));
            
            return employeeModel;
        }






        public static List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> employeeModelList=new List<EmployeeModel>();
            FileSystem file = new FileSystem();
            List<string> empId = file.RetrieveAllIds();
            for (int i = 0; i < empId.Count - 1; i++)
            { 
                employeeModelList.Add(GetEmployeeById(empId[i]));
            
            }
            return employeeModelList;
        }
        
    }
}
