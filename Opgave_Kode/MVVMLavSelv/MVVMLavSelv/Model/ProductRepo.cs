﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLavSelv.Model
{
    public class ProductRepo
    {
        public List<Product> products = new List<Product>
        {
            new Product {Name = "Apple", Price = 7.95},
            new Product {Name = "Orange", Price = 5.50},
            new Product {Name = "Banana", Price = 8.25}
        }; 
    }
}
