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
using Tavisca.EmployeeManagement.EnterpriseLibrary;
using System.Data.SqlClient;

namespace Tavisca.EmployeeManagement.FileStorage
{
    public class EmployeeStorage : IEmployeeStorage
    {
        readonly string EXTENSION = ".emp";

        public Model.Employee Save(Model.Employee employee)
        {
            try
            {
            //    if (Directory.Exists(Configurations.StoragePath) == false)
            //    {
            //        Directory.CreateDirectory(Configurations.StoragePath);
            //    }

            //    var filePath = GetFileName(employee.Id);
                 
            //    File.WriteAllText(filePath, JsonConvert.SerializeObject(employee));
            //    return employee;
            //
                SqlConnection connection = new SqlConnection("Data Source=Training9;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=test123!@#");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into EmployeeData values(@EmpId,@Title,@FirstName,@LastName,@Email,@Phone )", connection);
                SqlParameter p1 = new SqlParameter("EmpId", employee.Id);
                SqlParameter p2 = new SqlParameter("Title", employee.Title);
                SqlParameter p3 = new SqlParameter("FirstName", employee.FirstName);
                SqlParameter p4 = new SqlParameter("LastName", employee.LastName);
                SqlParameter p5 = new SqlParameter("Email", employee.Email);
                SqlParameter p6 = new SqlParameter("Phone", employee.Phone);
                //   SqlParameter p7 = new SqlParameter("Doj", employee.JoiningDate);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                //  cmd.Parameters.Add(p7);
                cmd.ExecuteNonQuery();
                connection.Close();
                return employee;         
            
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("data.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }

        public Model.Employee Get(string employeeId)
        {
            int flag = 0;
            try
            {
                //if (Directory.Exists(Configurations.StoragePath) == false)
                //{
                //    throw new DataAccessException("Invalid storage path configuration.");
                //}

                //var filePath = GetFileName(employeeId);

                //var employeeString = File.ReadAllText(filePath);
                //return JsonConvert.DeserializeObject<Model.Employee>(employeeString);

                Model.Employee employee = new Model.Employee();
                SqlConnection connection = new SqlConnection("Data Source=Training9;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=test123!@#");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from EmployeeData where EmpId='" + employeeId + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    employee.Id = dr[0].ToString();
                    employee.Title = dr[1].ToString();
                    employee.FirstName = dr[2].ToString();
                    employee.LastName = dr[3].ToString();
                    employee.Email = dr[4].ToString();
                    employee.Phone = dr[5].ToString();
                    flag = 1;

                }
                connection.Close();
                if (flag == 1)
                {
                    SqlConnection connection2 = new SqlConnection("Data Source=Training9;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=test123!@#");
                    Model.Remark remark = new Model.Remark();
                    SqlCommand cmd2 = new SqlCommand("select * from Remarks where EmpId='" + employeeId + "'", connection2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        remark.Text = dr2[2].ToString();
                        remark.CreateTimeStamp = Convert.ToDateTime(dr2[3]);
                        employee.Remarks.Add(remark);
                    }
                    connection2.Close();
                    return employee;
                }
                else
                {
                   // connection.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("data.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }

        public List<Model.Employee> GetAll()
        {
            //try
            //{
            //    if (Directory.Exists(Configurations.StoragePath) == false)
            //    {
            //        throw new DataAccessException("Invalid storage path configuration.");
            //    }

            //    var employees = new List<Model.Employee>();
            //    var fileNamesArray = Directory.GetFiles(Configurations.StoragePath, "*", SearchOption.TopDirectoryOnly);

            //    if (fileNamesArray != null && fileNamesArray.Length > 0)
            //    {
            //        var fileNames = fileNamesArray.ToList();
            //        fileNames.RemoveAll(file => Path.GetExtension(file).Equals(EXTENSION, StringComparison.OrdinalIgnoreCase) == false);
            //        fileNames.ForEach(fileName =>
            //            {
            //                var employeeString = File.ReadAllText(fileName);
            //                employees.Add(JsonConvert.DeserializeObject<Model.Employee>(employeeString));
            //            });
            //    }
            //    return employees;
            //}
            //catch (Exception ex)
            //{
            //    var rethrow = ExceptionPolicy.HandleException("data.policy", ex);
            //    if (rethrow) throw;
            //    return null;
            //}

            try
            {
                var employees = new List<Model.Employee>();
                Model.Employee employee = new Model.Employee();
                Model.Remark remark = new Model.Remark();
                SqlConnection connection = new SqlConnection("Data Source=Training9;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=test123!@#");
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from EmployeeData", connection);
                 
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    employee.Id = dr[0].ToString();
                    employee.Title = dr[1].ToString();
                    employee.FirstName = dr[2].ToString();
                    employee.LastName = dr[3].ToString();
                    employee.Email = dr[4].ToString();
                    employee.Phone = dr[5].ToString();

                    SqlCommand cmd2 = new SqlCommand("select * from Remarks where EmpId='" + employee.Id + "'", connection);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        remark.Text = dr2[2].ToString();
                        remark.CreateTimeStamp = Convert.ToDateTime(dr2[3]);
                        employee.Remarks.Add(remark);
                    }

                    employees.Add(employee);
                }

                connection.Close();
                return employees;
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("data.policy", ex);
                if (rethrow) throw;
                return null;
            }

        }

        private string GetFileName(string employeeId)
        {
            return string.Format(@"{0}\{1}.emp", Configurations.StoragePath, employeeId);
        }

        public Model.Remark SaveRemark(string employeeId, Model.Remark remark)
        {
            try
            {
                //    if (Directory.Exists(Configurations.StoragePath) == false)
                //    {
                //        Directory.CreateDirectory(Configurations.StoragePath);
                //    }

                //    var filePath = GetFileName(employee.Id);

                //    File.WriteAllText(filePath, JsonConvert.SerializeObject(employee));
                //    return employee;



                
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
