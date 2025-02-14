﻿using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SignIn()
        {
            return View();   
        }
        public IActionResult LogOut()
        {
            return RedirectToAction("SignIn", "Auth");
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return RedirectToAction("SignIn", "Auth");
        }
    }
}
