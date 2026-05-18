using Assignment_02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Services
{
    internal class ProductFilterService
    {
        public static List<Product> ProductFilter(List<Product> products, Predicate<Product> match)
        {
            List<Product>res = new List<Product>();
            foreach (Product product in products)
            {
                if(match(product))
                {
                    res.Add(product);
                }
            }
            return res;
        }
    }
}
