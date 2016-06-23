using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_FinalTermExam.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            Models.EmpService test = new Models.EmpService();
            ViewBag.EmpData = test.GetEmp();
            Models.EmpService empService = new Models.EmpService();
            ViewBag.selectResult = false;
            return View();
        }
    }
}