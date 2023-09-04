using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMMakeSelf.Model
{
    public class ProductRepo
    {
        public List<Product> products { get; set; } = 
            new List<Product>
        {
            new Product {Name = "Apple", Price = 7.95},
            new Product {Name = "Orange", Price = 5.50},
            new Product {Name = "Banana", Price = 8.25}
        };
        

        public List<Product> GetAll()
        {
            return products;
        }
        public Product Get(string name)
        {
            Product result = null;

            foreach (Product p in products)
            {
                if (p.Name == name)
                {
                    result = p;
                    break;
                }
            }

            return result;
        }
        //public void Remove(string name)
        //{

        //    Product foundProduct = this.Get(name);
        //    if (foundProduct != null)
        //        products.Remove(foundProduct);
        //    else
        //        throw new ArgumentException("Product with = " + name + "not found");

      
        //}
    }
}
