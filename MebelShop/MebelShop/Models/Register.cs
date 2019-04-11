using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MebelShop.Models
{
    public class Register
    {
        [Required,StringLength(200)]
        public string Firstname { get; set; }
        [Required, StringLength(200)]

        public string Lastname { get; set; }
        [Required, StringLength(200)]

        public string Email { get; set; }
        [Required, StringLength(200)]

        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }



    }
}
