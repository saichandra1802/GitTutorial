using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        EFTutorialEntities db = new EFTutorialEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return Json(db.Employees.ToList(),JsonRequestBehavior.AllowGet);
        }
    }
}