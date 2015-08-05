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
using Tavisca.Model.EmployeeService;

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
                PagenatedRemarkListResponse  response=GetRemarks(fetchedEmployee.Id, 1);
                if ( response.Status.StatusCode.Equals("200"))
                {
                    GridView1.VirtualItemCount=response.TotalCount;
                    GridView1.DataSource = response.Remarks;
                    GridView1.DataBind();
                }
            }
        }
        
        public PagenatedRemarkListResponse GetRemarks(string employeeId, int pageNumber)
        {
            return Transporter.GetRemarksById(employeeId, pageNumber.ToString()); ;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageNo = e.NewPageIndex;
            GridView1.PageIndex = pageNo;
            PagenatedRemarkListResponse response = GetRemarks(fetchedEmployee.Id,pageNo + 1);
            GridView1.VirtualItemCount = response.TotalCount;
            GridView1.DataSource =response.Remarks;
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