using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01.Entities
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }
        public BookStatus Status { get; set; }
        public Auther Auther { get; set; }
        public Book()
        {
            
        }
        public Book(string title, int numberofpages, double price, BookStatus status, Category category, Auther auther)
        {
            Title = title;
            NumberOfPages = numberofpages;
            Price = price;
            Status = status;
            Category = category;
            Auther = auther;
        }

        public override string ToString()
        {
            return $"Book ID: {BookID}, Book Name: {Title}";
        }

    }

    enum BookStatus
    {
        InStock,
        OutOfStock
    }
}
