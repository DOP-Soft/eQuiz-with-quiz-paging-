using eQuiz.Web.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eQuiz.Web.Areas.Student.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Student/Account
        public ActionResult Login()
        {
            return View();
        }
    }
}