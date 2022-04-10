using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class Transfer
    {
        public BankAccount From { get; }
        public BankAccount TargetAccount { get; }
        public int Money { get; set; }
        public int Id { get; set; }
    }
}
