using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CSharpDemo;
using CSharpDemo.Controllers;
using CSharpDemo.Models.ViewModel;

namespace CSharpDemo.Tests.Controllers
{
    [TestClass]
    public class ContactControllerTest : BaseTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            DemoController controller = new DemoController();

            // Act
            ViewResult result = controller.Calendar() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Create()
        {
            //// Arrange
            //ContactController controller = new ContactController();

            //var contact = new ContactViewModel()
            //{
            //    Name = "liuyi2",
            //    EnrollmentDate = DateTime.Now,
            //};

            //// Act
            //ViewResult result = controller.Create(contact) as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
        }
    }
}
