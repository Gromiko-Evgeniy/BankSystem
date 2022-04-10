using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Models.ViewModels
{
    public static class ChosenClientOptions
    {
        public static User? ChosenClient { get; set; }
        public static BankAccount? ChosenBankAccount { get; set; }
        //static Transfer ChosenTransfer { get; set; }
    }
}
