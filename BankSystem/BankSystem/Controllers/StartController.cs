using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Models;
using BankSystem.Models.ViewModels;

namespace BankSystem.Controllers
{
    public class StartController : Controller
    {
        [HttpGet]
        public IActionResult Welcome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Welcome(WelcomeResult result)
        {
            if (result.IsClient)
            {
                if (result.IsRegistered)
                {
                    return RedirectToAction("ClientLogin", "Client");
                }
                else
                {
                    return RedirectToAction("CLientRegistration", "Client");
                }
            }
            else
            {
                if (result.IsRegistered)
                {
                    return RedirectToAction("WorkerLogin", "Client");
                }
                else
                {
                    return RedirectToAction("WorkerRegistration", "Client");
                }
            }
        }
    }
}
