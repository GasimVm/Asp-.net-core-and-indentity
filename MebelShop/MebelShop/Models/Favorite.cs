using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MebelShop.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


    }
}
