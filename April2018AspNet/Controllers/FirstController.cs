using April2018AspNet.Models;
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
            string a = "This is new variable";
            return View();
        }

        public IActionResult Terms()
        {

            ViewBag.StudentName = "Usman Nazir";
            ViewBag.InstituteName = "Theta Solutions";


            Student S1 = new Student();
            S1.Id = 1;
            S1.Name = "Usman Nazir";
            S1.Mobile = "1321321";
            S1.Address = "Pakistan";
            S1.Email = "a@a.com";

            ViewBag.Student = S1;



            return View();
        }


    }
}