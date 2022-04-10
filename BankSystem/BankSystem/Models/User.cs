using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.Models
{
    public class User //добавить регулярнве выражения к полям 
    {
        public User(string firstName, string lastName, string passportNum, string personalID, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PassportNum = passportNum;
            this.PersonalID = personalID;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public User() { }

        [Required(ErrorMessage = "Please enter your name")]
        [RegularExpression(@"\D+", ErrorMessage = "Please enter а valid first name")]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]  
        [RegularExpression(@"\D+", ErrorMessage = "Please enter а valid last name")]
        [StringLength(15)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your passport number")]
        [RegularExpression(@"\d{7}[A|B|C|H|K|E|M]{1}\d{3}[PB|BA|BI]{1}\d{1}", ErrorMessage = "Please enter а valid passport number")]
        public string PassportNum { get; set; }

        [Required(ErrorMessage = "Please enter your personal ID from passport")]
        [RegularExpression(@"\d{2}\D{7}", ErrorMessage = "Please enter а valid passport ID")]
        public string PersonalID { get; set; }

        [Required(ErrorMessage = "Please enter your phone numЬer")]
        [RegularExpression(@"(\+[0-9]{1,3}[0-9]{9})|([0-9]{1,4}[0-9]{7})",
        ErrorMessage = "Please enter а valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"\w+\@\D+\.\D+",
        ErrorMessage = "Please enter а valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"\w{5,10}",
        ErrorMessage = "Password must contain between 5 and 10 alphanumeric characters")]
        public string Password { get; set; }
        public Company Company { get; set; } = null;
        public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
        public int Id { get; set; }
        public void removeBankAccount(BankAccount ba)
        {
            BankAccounts.Remove(ba);
        }

        public int MakeIDBankID() /////////////////////////////////////////////////////////////
        {
            return 0;
        }

        public void TransferMoney(BankAccount fromBA, BankAccount toBA)
        {
            //if (bankAccounts.Contains(fromBA))
        }
    }
}
