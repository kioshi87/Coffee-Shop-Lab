using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CoffeeShop.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter a UserName")]
        [StringLength(20, MinimumLength = 5)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter a Password")]
        [StringLength(20, MinimumLength = 6)]
        [DisplayName("Password" )]
        public string Password { get; set; }
    }
}
