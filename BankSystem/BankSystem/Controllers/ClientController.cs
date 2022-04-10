using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Models;
using BankSystem.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Controllers
{
    public class ClientController : Controller
    {
        private AppDbContext db;
        public ClientController(AppDbContext context)
        {
            db = context;
            db.Users.Include(u => u.BankAccounts).ThenInclude(ba => ba.Bank).ThenInclude(b => b.Clients);
            
            //var users = db.Users
            //    .Include(u => u.BankAccounts).ThenInclude(ba => ba.Bank).
            //    ThenInclude(b => b.BankAccount).ThenInclude(ba => ba.User);
            //db.BankAccounts.Include(ba => ba.User).ThenInclude(u => u.BankAccounts)
            //    .Include(ba => ba.Company).ThenInclude(c => c.BankAccount)
            //    .Include(ba => ba.Bank).ThenInclude(b => b.BankAccount);
        }

        [HttpGet]
        public IActionResult CLientRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CLientRegistration(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                ChosenClientOptions.ChosenClient = user;
                return RedirectToAction("ClientHome", user);
            }
            else { return View(); }
        }

        [HttpGet]
        public IActionResult ClientLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClientLogin(LoginData data)
        {
            User user = db.Users.FirstOrDefault(u => u.Email == data.Email);
            if (user == null)
            {
                ViewBag.ErrorMessage = "No client whith this e-mail found";
                return View();
            }
            if (user.Password != data.Password)
            {
                ViewBag.ErrorMessage = "Incorrect password";
                return View();
            }
            ChosenClientOptions.ChosenClient = user;
            return View("ClientHome", user);
        }

        public IActionResult ClientHome()
        {
            return View(ChosenClientOptions.ChosenClient);
        }

        public IActionResult ClientBankAccounts()
        {
            List<BankAccount> clientBankAccounts = db.BankAccounts.Where(ba => ba.User == ChosenClientOptions.ChosenClient).ToList();
            return View(clientBankAccounts);
        }

        public IActionResult A()
        {
            return View();
        }


    }
}
