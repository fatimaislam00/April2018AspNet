﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace April2018AspNet.Controllers
{
    public class ThirdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}