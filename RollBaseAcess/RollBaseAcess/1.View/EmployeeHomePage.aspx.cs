using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tavisca.Model;
using Tavisca.Model.EmployeeManagementService;

namespace RollBaseAcess
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected ClientEmployee fetchedEmployee=new ClientEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchedEmployee = (ClientEmployee)Session["Fetched_Employee_Object"];
            if (fetchedEmployee == null || fetchedEmployee.Title.Equals("HR"))
            {
                Response.Redirect("Login.aspx");
            }
            Label1.Text = "Hi," + fetchedEmployee.FirstName + ".View your reviews.";
            if (Page.IsPostBack == false)
            {
                
                if (fetchedEmployee.Remarks[0].Text.Equals("") == false)
                {
                    GridView1.VirtualItemCount = fetchedEmployee.Remarks.Count;
                    GridView1.DataSource = GetRemarks(fetchedEmployee.Id, 1);
                    GridView1.DataBind();
                }
            }
        }
        
        public List<Remark> GetRemarks(string employeeId, int pageNumber)
        {
            List<Remark> remarkList = Transporter.GetRemarksById(employeeId, pageNumber.ToString());
            return remarkList;
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageNo = e.NewPageIndex;
            GridView1.PageIndex = pageNo;
            GridView1.DataSource = GetRemarks(fetchedEmployee.Id, pageNo+1);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}