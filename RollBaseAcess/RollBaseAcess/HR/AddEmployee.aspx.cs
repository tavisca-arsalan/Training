using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;

namespace RollBaseAcess._1.View
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            ClientEmployee employee = new ClientEmployee();
            employee.FirstName = TextBox1.Text;
            employee.LastName = TextBox2.Text;
            employee.Title = TextBox3.Text;
            employee.Email = TextBox5.Text;
            employee.Phone = TextBox4.Text;
            employee.JoiningDate = DateTime.UtcNow;
            //Fix it.
            employee = employee.CreateEmployee();
            if (employee == null)
            {
                Label6.Text = "Could not add employee.";
                Label6.Visible = true;
            }
            else
            {
                //Session["Fetched Employee Object"] = employee;
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label6.Visible = true;
            }
        }
    }
}