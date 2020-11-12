using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWithUnitTest.Models;

namespace TestWithUnitTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public int Calculate(string roNum)
        {
            return new CalculatorModel().Calculator(roNum);
        }

    }
}