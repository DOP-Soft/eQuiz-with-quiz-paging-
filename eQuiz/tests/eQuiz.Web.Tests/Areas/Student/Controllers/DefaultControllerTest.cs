using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using StudentDefaultController = eQuiz.Web.Areas.Student.Controllers.DefaultController;

namespace eQuiz.Web.Tests.Areas.Student.Controllers
{
    [TestClass]
    public class DefaultControllerTest
    {
        private StudentDefaultController _controller;

        [TestInitialize]
        public void BeforeTestMethod()
        {
            _controller = new StudentDefaultController();
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
