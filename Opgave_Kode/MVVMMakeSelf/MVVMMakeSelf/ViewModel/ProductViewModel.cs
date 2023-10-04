using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMMakeSelf.Model;

namespace MVVMMakeSelf.ViewModel
{
    public class ProductViewModel
    {
        private Product product;

        public string Name { get; set; }
        public double Price { get; set; }

     public ProductViewModel (Product product)
        {
            this.product = product;
            Name = product.Name;
            Price = product.Price;
        }

        //public void RemoveProduct(ProductRepo productRepo)
        //{
        //    productRepo.Remove(product.Name);
        //}
    }
}
