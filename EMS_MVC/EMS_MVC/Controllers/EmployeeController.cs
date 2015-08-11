using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tavisca.Model;
using System.Runtime.Serialization;
using Tavisca.Model.EmployeeService;
using Tavisca.EMS.Security;

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
            if (HttpContext.User.IsInRole("HR") == true)
                return RedirectToAction("AddRemark", "Employee");
            else
                return RedirectToAction("ViewRemarks", "Employee");
            
        }

        [AllowAnonymous]
        public ActionResult AddEmployee()
        {
            if (HttpContext.User.IsInRole("HR") == false)
            {
                return RedirectToAction("Login", "Account");
            }
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
        public ActionResult ViewRemarks(int page=1)
        {
            int pageSize = 2;
            int totalPages = 0;
            int totalRemarks = 0;
             //trial for id=1:
            PagenatedRemarkListResponse remarkListResponse= Transporter.GetRemarksById((HttpContext.User as CustomPrincipal).Id , page.ToString());
            totalRemarks = remarkListResponse.TotalCount;
            totalPages = (totalRemarks / pageSize) + ((totalRemarks % pageSize) > 0 ? 1 : 0);
            List<Remark> remarks = remarkListResponse.Remarks.ToList();

            ViewBag.TotalRecords = totalRemarks;
            ViewBag.PageSize = 2;
            return View(remarks);
        }

        [AllowAnonymous]
        public ActionResult AddRemark(ClientRemark remark)
        {
            if (HttpContext.User.IsInRole("HR") == false)
            {
                return RedirectToAction("Login", "Account");
            }
            Dictionary<string, string> employeeDictionary = new Dictionary<string, string>();
            employeeDictionary = Transporter.GetAllEmployees();
            List<SelectListItem> employeeDetails = new List<SelectListItem>();
            foreach (var dictionary in employeeDictionary)
            {
                employeeDetails.Add(new SelectListItem { Text = dictionary.Value, Value = dictionary.Key});

            }
            ViewData["Employee"] = employeeDetails;
            if (Request["SelectedIndex"] != null)
            {
                string Id = Request["SelectedIndex"].ToString();
                remark.CreateTimeStamp = DateTime.UtcNow;
                ClientRemark addedRemark = Transporter.AddRemark(Id,remark.Text);
                if (addedRemark==null)
                {
                    ViewData["Label"] = "Error occurred while adding remark!!";
                    return View("AddRemark");
                }

                ViewData["Label"] = "Success!!";
                ModelState.Clear();
                return View("AddRemark");
            }
            ViewData["Label"] = "";
            return View("AddRemark");
        }
    }
}
