using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AdminDefaultController = eQuiz.Web.Areas.Admin.Controllers.DefaultController;

namespace eQuiz.Web.Tests.Areas.Admin.Controllers
{
    [TestClass]
    public class DefaultControllerTest
    {
        private AdminDefaultController _controller;

        [TestInitialize]
        public void BeforeTestMethod()
        {
            _controller = new AdminDefaultController();
        }

        [TestCleanup]
        public void AfterTestMethod()
        {
            _controller = null;
        }

        [TestMethod]
        public void Test_Index_Returns_ViewResult()
        {
            ActionResult result = _controller.Index();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

    }
}
