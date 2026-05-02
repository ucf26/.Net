using System.Net.Sockets;

namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // a. Try to create a plain Ticket object and show (in a comment) that the compiler prevents it.
            // Ticket ticket = new Ticket(); 
            // it is an abstract class, it cannot be instantiated 


            // b. Create one of each ticket type with hardcoded data. Book all three.
            VIPTicket T1 = new VIPTicket("Ali baba", 200m, true, 15m);
            IMAXTicket T2 = new IMAXTicket("el 7arrifa", 150m, false);
            StandardTicket T3 = new StandardTicket("Green mile", 130m, "A-3");

            T1.Book();
            T2.Book();
            T3.Book();

            // c. Add all three tickets to a Cinema and print them all (the print should go through the Cinema's reporting partial file).

            Cinema C1 = new Cinema();
            C1.OpenCinema();

            C1.AddTicket(T1);
            C1.AddTicket(T2);
            C1.AddTicket(T3);

            C1.PrintAllTickets();

            // d. Use polymorphism: loop through a Ticket[] array
            // and call the abstract method on each to show each type calculates differently.

            Ticket[] arrTemp = { T1, T2, T3 };

            for(int i = 0;i< arrTemp.Length; i++)
            {
                Console.WriteLine($"Price After Tax for Ticket {i+1} is: {arrTemp[i].PriceAfterTax()}");
            }

            // e. Call an extension method on a ticket to generate a receipt string and print it.
            T1.TicketInfo();
            T2.TicketInfo();
            T3.TicketInfo();

            // f.Call an extension method on the ticket array to calculate and print the total revenue.
            decimal tt = arrTemp.CalculateTotalRevenue();
            Console.WriteLine($"Total Array Price: {tt}");

            // g. Close the Cinema.
            C1.CloseCinema();

        }
    }
}
