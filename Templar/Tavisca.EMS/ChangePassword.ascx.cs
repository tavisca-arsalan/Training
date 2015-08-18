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
    public partial class ChangePassword : System.Web.UI.UserControl,IWidget
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
            ModifyPassword modify = new ModifyPassword();
            HttpCookie cookie = new HttpCookie("Logindetails");
            modify.Email = TextBoxEmail.Text;
            modify.OldPassword = TextBoxOldPassword.Text;
            modify.NewPassword = TextBoxNewPassword.Text;
            ModifyPasswordResponse response = modify.ChangePassword();
            Response.Write(response.ResponseCodes.Message);

            if (TextBoxConfirm.Text != TextBoxNewPassword.Text)
            {
                Response.Write(response.ResponseCodes.Message);
            }
        }
        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "";
            TextBoxOldPassword.Text = "";
            TextBoxNewPassword.Text = "";
            TextBoxConfirm.Text = "";
        }
    }
}