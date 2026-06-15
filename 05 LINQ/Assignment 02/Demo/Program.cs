using Assignment.Models;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static Assignment.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.Get top 3 most expensive products
        var q1 = ProductList
            .OrderByDescending(x => x.UnitPrice)
            .Take(3);
        q1.Print();
        Console.WriteLine(new string('-', 50));


        //2.show page 2 of products, with page size = 5
        var q2 = ProductList.Skip(1 * 5).Take(5);
        q2.Print();
        Console.WriteLine(new string('-', 50));


        //3.Take products from the list as long as Their UnitPrice is less than
        //$25(list is ordered by price).
        var q3 = ProductList
            .OrderBy(x => x.UnitPrice)
            .TakeWhile(x => x.UnitPrice < 25.0m);
        q3.Print();
        Console.WriteLine(new string('-', 50));


        //4.Check if ALL products in the "Seafood" category are in stock
        bool q4 = ProductList
            .Where(x => x.Category == "Seafood")
            .All(x => x.UnitsInStock > 0);
        Console.WriteLine(q4);
        Console.WriteLine(new string('-', 50));


        //5.Check if the ID list contains 9
        int[] ids = { 3, 9, 13, 18 };
        bool q5 = ids.Contains(9);
        Console.WriteLine(q5);
        Console.WriteLine(new string('-', 50));

        //6.Group all products by Category and print each group  with its
        //product count. 
        var groups = ProductList.GroupBy(p => p.Category);
        foreach(var productGroup in groups)
        {
            Console.WriteLine($"Product Category: {productGroup.Key}");
            foreach(var product in productGroup)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("=======================================");
        }

        Console.WriteLine(new string('-', 50));



        //7.Group products by Category and project only product names  per group
        var q7 = ProductList
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, Names = g.Select(p => new {p.ProductName}).ToList()});
        foreach(var g in q7)
        {
            Console.WriteLine(g.Category);
            Console.WriteLine(string.Join(", ", g.Names));
            Console.WriteLine("=======================================");

        }
        Console.WriteLine(new string('-', 50));

        //8.Find all categories that have MORE THAN 3 products
        var q8 = ProductList
            .GroupBy(p => p.Category)
            .Where(g => g.Count() > 3)
            .Select(g => new { CategoryName = g.Key, Count = g.Count() });
        Console.WriteLine("categories that have MORE THAN 3 products");
        q8.Print();
        Console.WriteLine(new string('-', 50));


        //9.Using QUERY SYNTAX, group customers by Country, and for  each
        //group select { Country, Count, TotalOrderValue }. 
        var q9 = from c in CustomerList
                 group c by c.Country into Customers
                 select new {Country = Customers.Key, Count = Customers.Count(), TotalOrderValue = Customers.SelectMany(c => c.Orders).Sum(o => o.Total)};

        q9.Print();
        Console.WriteLine(new string('-', 50));

        //10.Calculate the total number of units in stock across all products

        var q10QuerySyntax = (from p in ProductList
                              select p.UnitsInStock).Sum();

        var q10OperatorSyntax = ProductList.Sum(p => p.UnitsInStock);

        Console.WriteLine(q10QuerySyntax);
        //Console.WriteLine(q10OperatorSyntax);
        Console.WriteLine(new string('-', 50));


        //11.Find the CHEAPEST and MOST EXPENSIVE product prices
        var cheapest = ProductList.OrderByDescending(p => p.UnitPrice).FirstOrDefault();
        var mostExpensive = ProductList.OrderBy(p => p.UnitPrice).FirstOrDefault();
        Console.WriteLine($"Cheapest Product: {cheapest.ProductName}, and its Prica: {cheapest.UnitPrice}");
        Console.WriteLine($"Most Expensive Product: {mostExpensive.ProductName}, and its Prica: {mostExpensive.UnitPrice}");
        Console.WriteLine(new string('-', 50));


        //12.Get a distinct list of all product categories
        var DistinctCat = ProductList.GroupBy(p => p.Category).Select(g => g.Key).Distinct();
        Console.WriteLine("All Product Categories: ");
        DistinctCat.Print();
        Console.WriteLine(new string('-', 50));

        //13.find product IDs that are in setA but NOT in setB
        int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        int[] setB = { 3, 6, 9, 12, 15, 13 };

        var NotInB = setA.Except(setB);
        Console.WriteLine("IN A But Not In B");
        NotInB.Print();
        Console.WriteLine(new string('-', 50));



        //14.Find countries that  appear in list1 but NOT in list2
        //(case -insensitive). 
        string[] list1 = { "Germany", "France", "UK", "Spain" };
        string[] list2 = { "france", "SPAIN", "Italy" };
        var CountriesNotInB = list1.ExceptBy(list2.Select(c2 => c2.ToLower()), c1 => c1.ToLower());
        var CountriesNotInB1 = list1.Except(list1, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine("IN A But Not In B");
        CountriesNotInB.Print();
        Console.WriteLine(new string('-', 50));




        //15.Build a Dictionary<int, Product> keyed by ProductID. Then
        //retrieve and print the product with ID = 18.

        Dictionary<int, Product> mp = new Dictionary<int, Product>();

        foreach(Product p in ProductList)
        {
            mp.Add(p.ProductID, p);
        }

        Console.WriteLine(mp[18]);
        Console.WriteLine(new string('-', 50));

        //16.Get the first product whose price is greater than $50.
        var FirstGreaterThan50 = ProductList.First(p=>p.UnitPrice>50);
        Console.WriteLine(FirstGreaterThan50);
        Console.WriteLine(new string('-', 50));



        //17.Try to get the first product with a price > $500.it returns null
        //instead of throwing.
        var FirstGreaterThan500 = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
        Console.WriteLine(FirstGreaterThan500 == null?"Null": FirstGreaterThan500);
        Console.WriteLine(new string('-', 50));


        //18.Generate a multiplication table row for 7

        var table = Enumerable.Range(1, 10).Select(i => $"{i} * {7} = {7 * i}");
        table.Print();
        Console.WriteLine(new string('-', 50));


        //19.Generate even numbers between 1 and 30.
        var evenNumbers = Enumerable.Range(1, 30).Where(i => i % 2 == 0);
        evenNumbers.Print();
        Console.WriteLine(new string('-', 50));



        //20.Concatenate the first 3 product names with the first  3
        //customer company names into a single sequence.
        var names = ProductList
            .Select(p => p.ProductName).Take(3)
            .Concat(CustomerList.Select(c => c.CompanyName).Take(3));
        names.Print();
        Console.WriteLine(new string('-', 50));



        //21.Pair each product with a customer(by position)  and produce
        //a string "ProductName sold to CompanyName".

        var q21 = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
        q21.Print();

    }




}

public static class Extentions
{
    public static void Print<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }
}