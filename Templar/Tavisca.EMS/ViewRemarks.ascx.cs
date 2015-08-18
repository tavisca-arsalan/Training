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
    public partial class ViewRemarks : System.Web.UI.UserControl,IWidget
    {
        string employeeId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Pagination pagination = new Pagination();
                HttpClient client = new HttpClient();
                HttpCookie cookie = new HttpCookie("LoginDetails");
                employeeId = cookie["emp_Id"];
                PaginationResponse pageResponse = pagination.PaginationDisplay(employeeId, "1");
                if (pageResponse.ResponseCodes.Codes == "500")
                {
                    Response.Write(pageResponse.ResponseCodes.Message);
                }
                else
                {
                    GridViewRemark.DataSource = pageResponse.PaginationData.Remarks;
                    GridViewRemark.DataBind();
                    DataBindRepeater(GridViewRemark.PageIndex, GridViewRemark.PageSize, pageResponse.PaginationData.TotalPages);
                }
            }
        }

        private void DataBindRepeater(int totalRecords, int pageIndex, int pageSize)
        {
            int totalPages = totalRecords / pageSize;
            if ((totalRecords % pageSize) != 0)
                totalPages += 1;
            List<ListItem> pageData = new List<ListItem>();
            if (totalPages > 1)
            {
                for (int i = 0; i <= totalPages; i++)
                    pageData.Add(new ListItem(i.ToString(), i.ToString(), (i != pageIndex + 1)));
            }
            RepeaterPage.DataSource = pageData;
            RepeaterPage.DataBind();
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

        protected void GridViewRemark_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridViewRemark_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Pagination pagination = new Pagination();
            HttpClient client = new HttpClient();
            HttpCookie cookie = new HttpCookie("LoginDetails");
            employeeId = cookie["emp_Id"];
            PaginationResponse pageResponse = pagination.PaginationDisplay(employeeId, "1");
            if (pageResponse.ResponseCodes.Codes == "500")
            {
                Response.Write(pageResponse.ResponseCodes.Message);
            }
            else
            {
                GridViewRemark.DataSource = pageResponse.PaginationData.Remarks;
                GridViewRemark.DataBind();
                DataBindRepeater(GridViewRemark.PageIndex, GridViewRemark.PageSize, pageResponse.PaginationData.TotalPages);
            }
        }

        protected void LinkBotton_Click(object sender, EventArgs e)
        {
            int pageIndex = int.Parse((sender as LinkButton).CommandArgument);
            GridViewRemark.PageIndex = pageIndex;
            Pagination pagination = new Pagination();
            HttpClient client = new HttpClient();
            HttpCookie cookie = new HttpCookie("LoginDetails");
            employeeId = cookie["emp_Id"];
            PaginationResponse pageResponse = pagination.PaginationDisplay(employeeId, "1");
            if (pageResponse.ResponseCodes.Codes == "500")
            {
                Response.Write(pageResponse.ResponseCodes.Message);
            }
            else
            {
                pageIndex = -1;
                GridViewRemark.DataSource = pageResponse.PaginationData.Remarks;
                GridViewRemark.DataBind();
                DataBindRepeater(GridViewRemark.PageIndex, GridViewRemark.PageSize, pageResponse.PaginationData.TotalPages);
            }
        }
    }
}