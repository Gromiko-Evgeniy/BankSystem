using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    class Accountant : User
    {
        public Accountant(string firstName, string lastName, string passportNum, string personalID, string phoneNumber, string email) 
            : base(firstName, lastName, passportNum, personalID, phoneNumber, email)
        {

        }
    }
}
