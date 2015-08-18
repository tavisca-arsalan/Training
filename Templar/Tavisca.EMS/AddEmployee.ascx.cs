using LoginControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Templar.Contract;

namespace Tavisca.EMS
{
    public partial class AddEmployee : System.Web.UI.UserControl,IWidget
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void HideSettings()
        {
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

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Title = TextBoxTitle.Text;
            employee.FirstName = TextBoxFName.Text;
            employee.LastName = TextBoxLName.Text;
            employee.Email = TextBoxEmail.Text;
            employee.Designation = TextBoxDesignation.Text;
            employee.Phone = TextBoxContact.Text;

            EmployeeResponse response = employee.CreateEmployee();

            if (String.Equals(response.ResponseCodes.Codes, "500", StringComparison.OrdinalIgnoreCase) == false)
            {
                Label1.Visible = true;
                Label1.Text = "Employee Added Successfully";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Employee Creation Failed";
            }
        }
        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxTitle.Text = "";
            TextBoxFName.Text = "";
            TextBoxLName.Text = "";
            TextBoxEmail.Text = "";
            TextBoxPassword.Text = "";
            TextBoxContact.Text = "";
            TextBoxDesignation.Text = "";
        }
    }
}

