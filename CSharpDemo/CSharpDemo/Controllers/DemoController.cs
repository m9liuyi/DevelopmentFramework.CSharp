using CSharpDemo.PIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpDemo.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            ClientDemo cd = new ClientDemo();
            cd.GetDemoResult();

            return View();
        }

        public ActionResult UIFeatures()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult Charts()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Grid()
        {
            return View();
        }

        public ActionResult Icon()
        {
            return View();
        }

        public ActionResult Tour()
        {
            return View();
        }

        public ActionResult Contract()
        {
            return View();
        }
    }
}