using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;
using Tavisca.Model.EmployeeManagementService;

namespace RollBaseAcess
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientCredentials clientCredential = new ClientCredentials();

            clientCredential.EmailId = TextBox1.Text;
            clientCredential.Password = TextBox2.Text;
            //Fix it.
            ClientEmployee employee = clientCredential.Authenticate();

            if (employee == null)
            {
                // Invalid Credentials Provided
                Label3.Visible = true;
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            else
            {
                FormsAuthentication.SetAuthCookie(employee.Email.Trim(), false);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, employee.Email.Trim(), DateTime.UtcNow, DateTime.UtcNow.AddMinutes(10), false, employee.Title.Trim().ToLower());
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                Response.Cookies.Add(cookie);
                Session["employeeId"] = employee.Id.Trim();
                Session["userName"] = employee.Email.Trim();
                Session["employeeRole"] = employee.Title.Trim();
          
                String returnUrl;
                if (Request.QueryString["ReturnUrl"] == null)
                {
                    if(string.Equals(employee.Title.Trim(),"hr",StringComparison.OrdinalIgnoreCase))
                        returnUrl = "~/HR/AddRemark.aspx";
                    else
                        returnUrl = "~/1.View/EmployeeHomePage.aspx";
                }
                else
                {
                    returnUrl = Request.QueryString["ReturnUrl"];
                }
                Response.Redirect(returnUrl);
            }

        }
    }
}