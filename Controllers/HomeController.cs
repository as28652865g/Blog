﻿using Microsoft.AspNetCore.Mvc;

namespace EFBlog.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
