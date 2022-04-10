using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создание;
//b.Хранение;
//c.Снятие;
//d.Перевод;
//e.Накопление;
//f.Блокировка;
//g.Заморозка.
namespace BankSystem.Models
{
    public class BankAccount
    {
        public BankAccount(Bank bank, User User)
        {
            this.Bank = bank;
            this.User = User;
            bank.Clients.Add(User);
            User.BankAccounts.Add(this);
        }

        public BankAccount() { }
        public int MoneyCount { get; set; } = 0;
        public List<Transfer> Transfers { get; set; }
        [Required]
        public Bank Bank { get; set; }
        public User User { get; set; }
        public Company Company { get; set; }
        //public string BankAccID { get; } //?
        public int Id { get; set; }
    }
}

