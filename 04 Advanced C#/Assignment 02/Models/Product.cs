using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }


        // a parameterless consturctor must exist because we are using object initializer in Generate()
        public Product()
        {

        }

        public Product(int id, string name, string category, double price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }

        public static void PrintProducts(List<Product> items)
        {
            foreach (Product product in items)
            {
                Console.WriteLine(product);
            }
        }

        public override string ToString()
        {
            return $"{Name} - ${Price} (stock:{Stock})";
        }
    }
}
