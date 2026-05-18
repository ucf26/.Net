using Assignment_02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Services
{
    public static class ProductReportService
    {
        public static void PrintReport(List<Product> lst, Action<Product> print)
        {
            foreach(Product item in lst)
            {
                print(item);
            }
        }


        public static void TransformProduct(List<Product> lst, Action<Product> action)
        { 
            foreach (Product item in lst)
            {
                action(item);
            }
        }


    }
}
