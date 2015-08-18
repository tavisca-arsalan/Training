using LoginControl.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Templar.Contract;

namespace Tavisca.EMS
{
    public partial class AddRemark : System.Web.UI.UserControl, IWidget
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllEmployeeResponse allEmployees = new GetAllEmployeeResponse();
            Dictionary<string, string> employeeDictionary = new Dictionary<string, string>();
            allEmployees = GetAllEmployeeResponse.GetEmpList();
            foreach (Employee employee in allEmployees.GetAllEmployee)
            {
                employeeDictionary.Add(employee.Id.ToString(), employee.FirstName + "  " + employee.LastName);
            }
            DropDownList1.DataTextField = "Value";
            DropDownList1.DataValueField = "Key";
            DropDownList1.DataSource = employeeDictionary;
            DropDownList1.DataBind();
        }

        public void HideSettings()
        {
            //throw new NotImplementedException();
            Panel1.Visible = false;
        }

        public new void Init(IWidgetHost host)
        {
            //throw new NotImplementedException();
        }

        public void ShowSettings()
        {
            Panel1.Visible = true;
        }

        protected void AddRemarkButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Remark remark = new Remark();
            string employeeId = DropDownList1.Text;
            employee.Id = Convert.ToInt32(DropDownList1.Text);
            remark.Text = TextArearemark.Value;
            remark.CreateTimeStamp = DateTime.UtcNow;
            RemarkResponse response = remark.AddRemark(employeeId, remark);
            TextArearemark.InnerText = null;
            DropDownList1.SelectedIndex = -1;
        }
    }
}