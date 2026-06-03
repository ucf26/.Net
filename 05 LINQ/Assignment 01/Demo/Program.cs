using Assignment.Models;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
using static Assignment.DataSources.Source;
namespace Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        //  1. Get all products from the "Seafood" category. Print each 
        // product's name and price.

        var seafoodcat = ProductList.Where(p => p.Category == "Seafood")
                                    .Select(p=> new {p.ProductName, p.UnitPrice});
        seafoodcat.Print();
        Console.WriteLine(new string('=', 50));

        //  2. Get a list of only the product names from ProductList. Print 
        //  each name.

        var SeaFoodProdNames = ProductList.Select(p => new { p.ProductName });
        SeaFoodProdNames.Print();
        Console.WriteLine(new string('=', 50));


        //  3.Sort all products by UnitPrice(ascending). Print each
        //  product's name and price.   

        var ProdSortedByPrice = ProductList.OrderBy(p=>p.UnitPrice);
        ProdSortedByPrice.Print();
        Console.WriteLine(new string('=', 50));

        // 4.Get all products where UnitPrice is between 10 and 30
        var ProdBetween10and30 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
        ProdBetween10and30.Print();
        Console.WriteLine(new string('=', 50));

        // 5.Get all products that are in stock(UnitsInStock > 0) and
        // belong to the "Condiments" category.

        var CondimentsandInStock = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
        CondimentsandInStock.Print();
        Console.WriteLine(new string('=', 50));


        // 6.Create a new anonymous type with three properties: 
        // ● Name → the product name
        // ● Price → the unit price
        // ● StockStatus → a string: "Available" if UnitsInStock > 0, 
        // otherwise "Out of Stock"
        // ● Print the result.

        var AnonymousProduct = ProductList.Select(p => new
        {
            Name = p.ProductName,
            Price = p.UnitPrice,
            StockStatus = p.UnitPrice > 0 ? "Available" : "Out Of Stock"
        });
        AnonymousProduct.Print();

        // 7.Print each product's name along with its position (1-based) 
        // in the list. Expected format: 1.Chai, 2.Chang, etc.
        var prodNames = ProductList.Select((p, i) => new { i, p.ProductName });
        foreach( var prod in prodNames)
        {
            Console.WriteLine($"{prod.i}.{prod.ProductName}");
        }
        Console.WriteLine(new string('=', 50));

        // 8.Sort ProductList by Category ascending, then within each
        // category, sort by UnitPrice descending. 
        var CategorySort = ProductList.OrderBy(p => p.Category).ThenByDescending(p=>p.UnitPrice);
        CategorySort.Print();
        Console.WriteLine(new string('=', 50));

        // 9.Get all products from the "Beverages" category, sorted by
        // UnitsInStock descending. Print name and stock. 
        var BeveragesProd = ProductList.Where(p => p.Category == "Beverages")
                                       .OrderByDescending(p => p.UnitsInStock)
                                       .Select(p => new { Name = p.ProductName, Stock = p.UnitsInStock });
        BeveragesProd.Print();
        Console.WriteLine(new string('=', 50));

        // 10.Using QUERY SYNTAX with a compound from clause, list
        // all orders placed in 1997 or later showing CustomerID and
        // OrderDate.
        var leterOrders = CustomerList.SelectMany(c => c.Orders, (x, y) => new { x.CustomerID, y});
        leterOrders.Print();
        Console.WriteLine(new string('=', 50));


        // 11.Show position number along side ProductName
        var IndexedProd = ProductList.Select((p, i) => new { Index = i, Name = p.ProductName });
        IndexedProd.Print();
        Console.WriteLine(new string('=', 50));

        // 12.Sort first by-word length and then by a 
        // case -insensitive sort of the words in an array.
        String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedArr = Arr.OrderBy(s => s.Length).ThenBy(s => s);
        sortedArr.Print();
        Console.WriteLine(new string('=', 50));


        //13.Create a list of all digits in the array whose second
        //letter is 'i' that is reversed from the order in the
        //original array.


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