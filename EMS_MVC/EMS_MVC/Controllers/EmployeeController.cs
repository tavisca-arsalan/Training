using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tavisca.Model;
using System.Runtime.Serialization;
using Tavisca.Model.EmployeeService;

namespace EMS_MVC.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AddEmployee()
        {
            ViewData["Status"] = "";
            return View("AddEmployee");
        }

        [AllowAnonymous]
        public ActionResult SaveEmployee(Tavisca.Model.ClientEmployee employee)
        {
            employee.JoiningDate = DateTime.UtcNow;
            try
            {
                employee = employee.CreateEmployee();
                return View("AddEmployee");
            }
            catch (Exception)
            {
                ViewData["Status"] ="Failed to add the employee record";
                return View("AddEmployee");
            }
           
        }

        [AllowAnonymous]
        public ActionResult ViewRemarks(int pageNumber)
        {
            int pageSize = 2;
            int totalPages = 0;
            int totalRemarks = 0;
             //trial for id=1:
            PagenatedRemarkListResponse remarkListResponse= Transporter.GetRemarksById("1", pageNumber.ToString());
            totalRemarks = remarkListResponse.TotalCount;
            totalPages = (totalRemarks / pageSize) + ((totalRemarks % pageSize) > 0 ? 1 : 0);
            List<Remark> remarks = remarkListResponse.Remarks.ToList();

            ViewBag.TotalRecords = totalRemarks;
            ViewBag.PageSize = 2;
            return View(remarks);
        }

    }
}
