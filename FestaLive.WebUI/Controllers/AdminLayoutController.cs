﻿using Microsoft.AspNetCore.Mvc;

namespace FestaLive.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
