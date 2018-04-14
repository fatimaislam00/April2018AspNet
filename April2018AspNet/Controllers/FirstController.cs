using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace April2018AspNet.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }


    }
}