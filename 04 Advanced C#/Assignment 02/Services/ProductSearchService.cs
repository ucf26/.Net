using Assignment_02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Services
{
    public static class ProductSearchService
    {
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> Valid)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in products)
            {
                if (Valid(item))
                    result.Add(item);
            }
            return result;
        }
    }
}
