using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;
using Tavisca.Model.EmployeeManagementService;

namespace RollBaseAcess._1.View
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected string employeeEmail; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["employeeId"] == null)
                Response.Redirect("~/1.View/Login.aspx");
            else
            {
                employeeEmail = (string)Session["userName"];
                TextBox1.Text = employeeEmail;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientCredentialModifier clientCredentialModifier = new ClientCredentialModifier();
            clientCredentialModifier.EmailId = TextBox1.Text;
            clientCredentialModifier.OldPassword = TextBox2.Text;
            clientCredentialModifier.NewPassword = TextBox3.Text;
            if (employeeEmail.Equals(clientCredentialModifier.EmailId))
            {
                int result = clientCredentialModifier.ChangePassword();

                if (result == 0)
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    Label5.Visible = true;
                }
                else if (result == 1)
                {
                    Label6.Visible = true;
                    //TO DO: Make it stay for some time
                    Response.Redirect("~/1.View/Login.aspx");

                }
            }
            else
            {
                Label5.Visible = true;
            }
        
        }
    }
}