﻿using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
