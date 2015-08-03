using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;

namespace RollBaseAcess._1.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void Calender1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        protected void Button4_Click(object sender, EventArgs e)
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
    }
}