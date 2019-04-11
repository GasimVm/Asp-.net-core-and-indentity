using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MebelShop.Models
{
    public class ApplicationUser :IdentityUser
    { [StringLength(300),Required]
        public string FirstName { get; set; }
        [StringLength(200)]
        public string Lastname { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }



    }
}
