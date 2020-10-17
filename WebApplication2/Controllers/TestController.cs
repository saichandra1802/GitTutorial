using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            TestModel ts = new TestModel();
            ts.Gender = "M";
            ts.Name = "Test";
            return View(ts);
        }
        [HttpPost]
        public ActionResult save(TestModel ts)
        {
           
            ts.Gender = "M";
            ts.Name = "Test";
            return View(ts);
        }
    }
}