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
    public class HomeControllerTest
    {
        private HomeController _controller;

        [TestInitialize]
        public void BeforeTestMethod()
        {
            _controller = new HomeController();
        }

        [TestCleanup]
        public void AfterTestMethod()
        {
            _controller = null;
        }

        [TestMethod]
        public void Test_Index_Returns_RedirectToActionResult()
        {
            ActionResult result = _controller.Index();
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod]
        public void Test_Index_Returned_Route()
        {
            RedirectToRouteResult result = (RedirectToRouteResult)_controller.Index();
            string action = (string)result.RouteValues["action"];
            string controller = (string)result.RouteValues["controller"];

            Assert.AreEqual("Index", action, true);
            Assert.AreEqual("Account", controller, true);
        }
    }
}
