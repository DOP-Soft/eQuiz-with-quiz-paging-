using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ModeratorDefaultController = eQuiz.Web.Areas.Moderator.Controllers.DefaultController;

namespace eQuiz.Web.Tests.Areas.Moderator.Controllers
{
    [TestClass]
    public class DefaultControllerTest
    {
        private ModeratorDefaultController _controller;

        [TestInitialize]
        public void BeforeTestMethod()
        {
            _controller = new ModeratorDefaultController();
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
