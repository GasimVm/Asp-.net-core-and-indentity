using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MebelShop.Models
{
    public class Product
    {
         
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        public int Price { get; set; }
        [Required, StringLength(400)]
        public string Description { get; set; }

        public bool News { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
       

    }
}
