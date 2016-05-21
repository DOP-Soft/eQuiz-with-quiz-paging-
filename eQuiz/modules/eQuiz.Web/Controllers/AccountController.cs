using eQuiz.Web.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eQuiz.Web.Controllers
{
    public class AccountController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string role)
        {
            switch(role)
            {
                case "moderator":
                    return RedirectToAction("Index", "Default", new { area = "Moderator" });
                case "student":
                    return RedirectToAction("Index", "Default", new { area = "Student" });                    
                case "admin":
                    return RedirectToAction("Index", "Default", new { area = "Admin" });                    
                default:
                    return View();
            }
            
        }
    }
}