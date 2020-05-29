using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreWebMvcApp01.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld/Welcome
        public IActionResult Welcome(string name = "Some Body", int numTimes = 99)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}