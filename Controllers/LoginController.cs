﻿using Microsoft.AspNetCore.Mvc;

namespace EFBlog.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
