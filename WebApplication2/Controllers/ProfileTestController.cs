﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ProfileTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}