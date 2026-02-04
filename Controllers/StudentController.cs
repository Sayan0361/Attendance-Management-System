using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attendance_Management_System.Controllers
{
    public class StudentController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register()
        //{
        //    // Registration logic here
        //    return RedirectToAction("Index");
        //}
    }
}