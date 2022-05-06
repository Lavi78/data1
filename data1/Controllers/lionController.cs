using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace data1.Controllers
{
    public class lionController : Controller
    {
        anoopEntities obj = new anoopEntities();
        // GET: lion
        public ActionResult Index()
        {
            List<Employee> employees = obj.Employees.ToList();
            return View(employees);
        }
    }
}