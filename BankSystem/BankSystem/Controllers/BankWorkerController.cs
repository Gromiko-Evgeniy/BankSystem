using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.Models;
using BankSystem.Models.ViewModels;

namespace BankSystem.Controllers
{
    public class BankWorkerController : Controller
    {
        private AppDbContext db;
        public BankWorkerController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult List()
        {
            return View(db.Users.ToList());
                //Where(u => u.BankAccounts.Where(ba => 
                //ba.Bank.LegalName == ChosenWorkerOptions.ChosenWorker.Company.LegalName)).ToList());
        }

        //public IActionResult Details(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = db.Users.FirstOrDefault(p => p.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}

        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = db.Users.FirstOrDefault(p => p.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public IActionResult Edit(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Users.Update(user);
        //        db.SaveChanges();
        //        return RedirectToAction("List");
        //    }
        //    else { return View(); }
        //}

        //[HttpGet]
        //[ActionName("Delete")]
        //public IActionResult ConfirmDelete(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = db.Users.FirstOrDefault(u => u.Id == id);
        //        if (user != null)
        //            return View(user);
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public IActionResult Delete(int? id)
        //{
        //    if (id != null)
        //    {
        //        User user = db.Users.FirstOrDefault(p => p.Id == id);
        //        if (user != null)
        //        {
        //            db.Users.Remove(user);
        //            db.SaveChanges();
        //            return RedirectToAction("List");
        //        }
        //    }
        //    return NotFound();
        //}

    }
}
