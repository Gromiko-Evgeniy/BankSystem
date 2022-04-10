using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BankSystem.Models
{
    public class Company
    {

        //Юридический адрес
        //УНП это единый уникальный номер на всей территории РБ, который присваивается каждому плательщику при постановке на учет в налоговом органе и используется по всем налогам, сборам,

        [Required(ErrorMessage = "Please enter company legal name")]
        [RegularExpression(@"\D+", ErrorMessage = "Please enter а valid legal name")]
        public string LegalName { get; set; }
        public BankAccount BankAccount { get; set; }
        public int BankAccountId { get; set; }
        public List<User> Workers { get; set; }
        public int Id { get; set; }

    }
}