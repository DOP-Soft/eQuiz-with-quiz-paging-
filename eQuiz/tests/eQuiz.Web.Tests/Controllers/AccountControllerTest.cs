using eQuiz.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace eQuiz.Web.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        private AccountController _controller;

        [TestInitialize]
        public void BeforeTestMethod()
        {
            _controller = new AccountController();
        }

        [TestCleanup]
        public void AfterTestMethod()
        {
            _controller = null;
        }

        [TestMethod]
        public void Test_GetIndex_Returns_ViewResult()
        {
            ActionResult result = _controller.Index();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Test_PostIndex_Redirects_to_AdminDefaultController()
        {
            string role = "admin";
            RedirectToRouteResult result = (RedirectToRouteResult)_controller.Index(role);            

            string action = (string)result.RouteValues["action"];
            string controller = (string)result.RouteValues["controller"];
            string area = (string)result.RouteValues["area"];

            Assert.AreEqual("Index", action, true);
            Assert.AreEqual("Default", controller, true);
            Assert.AreEqual("Admin", area, true);
        }

        [TestMethod]
        public void Test_PostIndex_Redirects_to_ModeratorDefaultController()
        {
            string role = "moderator";
            RedirectToRouteResult result = (RedirectToRouteResult)_controller.Index(role);

            string action = (string)result.RouteValues["action"];
            string controller = (string)result.RouteValues["controller"];
            string area = (string)result.RouteValues["area"];

            Assert.AreEqual("Index", action, true);
            Assert.AreEqual("Default", controller, true);
            Assert.AreEqual("Moderator", area, true);
        }

        [TestMethod]
        public void Test_PostIndex_Redirects_to_StudentDefaultController()
        {
            string role = "student";
            RedirectToRouteResult result = (RedirectToRouteResult)_controller.Index(role);

            string action = (string)result.RouteValues["action"];
            string controller = (string)result.RouteValues["controller"];
            string area = (string)result.RouteValues["area"];

            Assert.AreEqual("Index", action, true);
            Assert.AreEqual("Default", controller, true);
            Assert.AreEqual("Student", area, true);
        }
    }
}
