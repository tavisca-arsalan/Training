using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EMS_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Add Employee",
               url: "employee/add",
               defaults: new { controller = "Employee", action = "AddEmployee"}
           );

            routes.MapRoute(
              name: "Employee HomePage",
              url: "employee/home",
              defaults: new { controller = "Employee", action = "ViewRemarks" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}