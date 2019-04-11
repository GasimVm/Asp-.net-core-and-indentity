using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MebelShop.Models
{
    public class Images
    {
        
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
