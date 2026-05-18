using Assignment_02.Data;
using Assignment_02.Models;
using Assignment_02.Services;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = ProductRepository.Generate();

            // Task 01 : Smart Product Search
            Console.WriteLine("\n============================ Searching ============================\n");

            // 1. All Electronics products 
            var ElectronicsProducts = ProductSearchService.SearchProducts(Products, P => P.Category == "Electronics");
            Console.WriteLine("-- Electronics --");
            Product.PrintProducts(ElectronicsProducts);
            Console.WriteLine("\n\n");

            //2.Products cheaper than $50
            var CheapProducts = ProductSearchService.SearchProducts(Products, prod => prod.Price < 50);
            Console.WriteLine("-- Under 50$ --");
            Product.PrintProducts(CheapProducts);
            Console.WriteLine("\n\n");

            //3.Products that are in stock(Stock > 0)
            var ProductsInStock = ProductSearchService.SearchProducts(Products,prod => prod.Stock > 0);
            Console.WriteLine("-- In Stock --");
            Product.PrintProducts(ProductsInStock);
            Console.WriteLine("\n\n");

            //4.Clothing products under $100
            var ClothingUnder100Products = ProductSearchService.SearchProducts(Products, prod => prod.Category == "Clothing" && prod.Price < 100);
            Console.WriteLine("-- Cloting less than 100$ --");
            Product.PrintProducts(ClothingUnder100Products);
            Console.WriteLine("\n\n");


            // Task 03 : Custom Report Generator

            // 3.1  Print Reports 
            Console.WriteLine("\n============================ Reporting ============================\n");
            // Scenario 1  Short Report: Print each product as Name - $Price 
            Console.WriteLine("\n--- Short Report --- \n");
            ProductReportService.PrintReport(ProductsInStock, prod => Console.WriteLine($"{prod.Name} - ${prod.Price}"));
            Console.WriteLine("\n\n");

            // Scenario 2  Detailed Report: Print each product as [Category] Name | Price: $X | Stock: Y
            Console.WriteLine("\n--- Detailed Report ---\n");
            ProductReportService.PrintReport(ProductsInStock, prod => Console.WriteLine($"[{prod.Category}] {prod.Name} | Price: ${prod.Price} | Stock:{prod.Stock}"));
            Console.WriteLine("\n\n");

            // 3.2. Transform Products 

            // Scenario 3 Summary List: Transform each product into a string like "Laptop ($1200)". Print all results. 
            Console.WriteLine("\n--- Summary List ---\n");
            ProductReportService.TransformProduct(Products, prod => Console.WriteLine($"{prod.Category} (${prod.Price})"));
            Console.WriteLine("\n\n");

            // Scenario 4 Price Label: Transform each product into "Expensive!" if Price > $100, or "Affordable" otherwise. Print each as Name: Label.
            Console.WriteLine("\n--- Price Label ---\n");
            ProductReportService.TransformProduct(Products, prod => Console.WriteLine($"{prod.Category}: {(prod.Price > 100? "Expensive!": "Affordable")}"));
            Console.WriteLine("\n\n");

            //3.3. Filter Products 

            //Scenario 5  Low-Stock Alert: Find products with Stock < 20 and print an alert for each in the format: [LOW STOCK] Name: only X left!
            List<Product> lowStock = ProductFilterService.ProductFilter(Products, prod => prod.Stock < 20);
            Console.WriteLine("--- Low-Stock Alert --- ");
            foreach(Product product in lowStock)
            {
                Console.WriteLine($"[Low Stock] {product.Category} Only {product.Stock} Left!");
            }

        }
    }
}
