using Assignment_01.Context;
using Assignment_01.Entities;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var BookStore = new BookStoreDbContext();
            {
                Auther A1 = new Auther("George", "Martin", "george.martin@books.com", "Fantasy author", new DateTime(1948, 9, 20));
                Auther A2 = new Auther("J.K.", "Rowling", "jk.rowling@books.com", "Magical storyteller", new DateTime(1965, 7, 31));
                Auther A3 = new Auther("Stephen", "King", "stephen.king@books.com", "Horror and thriller expert", new DateTime(1947, 9, 21));

                BookStore.Authers.Add(A1);
                BookStore.Authers.Add(A2);
                BookStore.Authers.Add(A3);

                Category C1 = new Category("Fiction", "Novels and short stories", CategoryStatus.Active);
                Category C2 = new Category("Technology", "Programming and IT books", CategoryStatus.Active);
                Category C3 = new Category("History", "Historical narratives", CategoryStatus.InActive);

                BookStore.Categories.Add(C1);
                BookStore.Categories.Add(C2);
                BookStore.Categories.Add(C3);

                Book B1 = new Book("Game of Thrones", 694, 29.99, BookStatus.InStock, C1, A1);
                Book B2 = new Book("Harry Potter", 309, 19.99, BookStatus.InStock, C2, A2);
                Book B3 = new Book("The Shining", 447, 24.99, BookStatus.OutOfStock, C3, A3);
                Book B4 = new Book("C# Programming", 512, 39.99, BookStatus.InStock, C1, A2);

                BookStore.Books.Add(B1);
                BookStore.Books.Add(B2);
                BookStore.Books.Add(B3);
                BookStore.Books.Add(B4);

                BookStore.SaveChanges();


                var query = BookStore.Books.Where(b => b.Auther.LastName == "Martin");
                foreach (var item in query)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
        }
    }
}
