using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MVVMLavSelv.Model;

namespace MVVMLavSelv.ViewModel
{
    public class ProductViewModel
    {
       private Product product;

        public string Name { get; set; }
        public double Price { get; set; }

        public ProductViewModel(Product product)
        {
            this.product = product;
            Name = product.Name;
            Price = product.Price;
        }
    }
}
