using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class Bank
    {
        public Bank(string legalName, string BIdC) 
        {
            this.LegalName = legalName;
            this.BankIDCode = BIdC;
        }
        public Bank() {}
        
        
        [Required(ErrorMessage = "Please enter company legal name")]
        [RegularExpression(@"\D+", ErrorMessage = "Please enter а valid legal name")]
        public string LegalName { get; set; }
        [Required(ErrorMessage = "Please enter a bank identification code")]
        [RegularExpression(@"\w{8}", ErrorMessage = "Please enter а valid  bank identification code")]
        public string BankIDCode { get; set; }
        //[ForeignKey("BankId")]
        //public List<User> Workers { get; set; } = new List<User>();
        //[ForeignKey("BankId")]
        public List<User> Clients { get; set; } = new List<User>();
        public List<Company> CompaniesAsClients { get; set; } = new List<Company>();
        public int Id { get; set; }
        public int UserId { get; set; }

    }
}
