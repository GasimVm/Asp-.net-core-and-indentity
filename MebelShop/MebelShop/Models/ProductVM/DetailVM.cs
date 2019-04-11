using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MebelShop.Models.ProductVM
{
    public   class DetailVM
    {
        public  Product Product { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Images> Images { get; set; }
    }
}
