using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem.Models.ViewModels
{
    public class LoginData
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"\w+\@\D+\.\D+",
        ErrorMessage = "Please enter а valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required to create an account")]
        [RegularExpression(@"\w{5,10}",
        ErrorMessage = "Password must contain between 5 and 10 alphanumeric characters")]
        public string Password { get; set; }
    }
}
