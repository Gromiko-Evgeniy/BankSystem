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
    public class BankAccountController : Controller
    {
        private AppDbContext db;
        public BankAccountController (AppDbContext context)
        { 
            db = context;
            db.BankAccounts.Include(ba => ba.Bank).ThenInclude(b => b.Clients);
        }

        [HttpGet]
        public IActionResult AddBankAccount()
        {
            //var banks = db.Banks.Include(b => b.BankAccount).ToList();
            return View(db.Banks.ToList());
        }
        
        [HttpPost]
        public IActionResult AddBankAccount(string bankName)
        {
            var bank = db.Banks.FirstOrDefault(b => b.LegalName.Equals(bankName));
            BankAccount ba = new BankAccount(bank, ChosenClientOptions.ChosenClient);
            //return Content(ba.Bank.LegalName + ba.User.FirstName);
            db.BankAccounts.Add(ba);
            db.SaveChanges();
            return RedirectToAction("ClientBankAccounts", "Client",
                db.BankAccounts.Where(ba => ba.User == ChosenClientOptions.ChosenClient).ToList());
        }
    }
}
