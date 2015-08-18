using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Templar.Contract;
using LoginControl.Model;
using System.Web.Security;

namespace Tavisca.EMS
{
    public partial class Login : System.Web.UI.UserControl,IWidget
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null)
                    TextBoxName.Text = Request.Cookies["Email"].Value;
                if (Request.Cookies["Password"] != null)
                    TextBoxPassword.Attributes.Add("value", Request.Cookies["Password"].Value);
                if (Request.Cookies["Email"] != null && Request.Cookies["Password"] != null)
                    CheckBoxRememberMe.Checked = true;
            } 
        }

        public void HideSettings()
        {
            //throw new NotImplementedException();
        }

        public new void Init(IWidgetHost host)
        {
            //throw new NotImplementedException();
        }

        public void ShowSettings()
        {
            Panel1.Visible = true;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            LoginDetails details = new LoginDetails();
            details.Email = TextBoxName.Text;
            details.Password = TextBoxPassword.Text;
            HttpClient client = new HttpClient();

            var response = client.UploadData<LoginDetails, EmployeeResponse>("http://localhost:53412/EmployeeManagementService.svc/login", details);
            FormsAuthentication.SetAuthCookie(details.Email.Trim(), false);
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, details.Email.Trim(), DateTime.UtcNow, DateTime.UtcNow.AddMinutes(10), false, response.EmployeeRequest.Designation.Trim().ToLower());
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));

            if (response.ResponseCodes.Codes == "500")
            {
                Response.Write(response.ResponseCodes.Message);
            }
            else
            {
                cookie["Email"] = response.EmployeeRequest.Email;
                cookie["Password"] = response.EmployeeRequest.Password;
                Response.Cookies.Add(cookie);

                if (CheckBoxRememberMe.Checked == true)
                {
                    Response.Cookies["Email"].Value = response.EmployeeRequest.Email; ;
                    Response.Cookies["Email"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["Password"].Value = response.EmployeeRequest.Password;
                    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(1);
                }

                if (string.Equals(response.EmployeeRequest.Designation.Trim(), "hr", StringComparison.OrdinalIgnoreCase))
                {
                    Response.Redirect("HomePageHR");
                }
                else
                {
                    Response.Redirect("ViewRemarks");
                }
            }
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Text = "";
            TextBoxName.Text = "";
            CheckBoxRememberMe.Checked = false;
        }
    }
}