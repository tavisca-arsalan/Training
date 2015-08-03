using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;


namespace RollBaseAcess
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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
            Session["Fetched Employee Object"] = employee;
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}