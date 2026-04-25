namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // a.Create a Cinema and open it.

            Cinema C1 = new Cinema();
            C1.OpenCinema();


            // b.Create one of each ticket type (hardcoded data) and add them to the Cinema.

            VIPTicket T1 = new VIPTicket("Inception", 15.00m, true, 50);
            IMAXTicket T2 = new IMAXTicket("Avatar", 12.00m, true);
            StandardTicket T3 = new StandardTicket("The Matrix", 10.00m, "A-5");

            T1.Book();
            T2.Book();
            T3.Book();

            C1.AddTicket(T1);
            C1.AddTicket(T2);
            C1.AddTicket(T3);

            // c.Print all tickets through the Cinema.

            C1.PrintAllTickets();

            // d.Clone a VIP ticket, change the clone's movie name, and print both to prove independence.
            Console.WriteLine("\n======================================== After Cloning ========================================\n");
            VIPTicket Cloned = (VIPTicket)T1.Clone();
            Cloned.MovieName = "El 7abbiba";
            T1.Print();
            Cloned.Print();

            // e. Cancel one ticket and reprint it to show the updated status.

            T1.Cancel();
            Console.WriteLine("\n======================================== After Cancelling ========================================\n");
            T1.Print();


            // f. Use the utility method to print an array of printable tickets.
            Console.WriteLine("\n======================================== Using The Utility Method ========================================\n");

            BookingHelper.Print(T1);
            BookingHelper.Print(T2);
            BookingHelper.Print(T3);
            Console.WriteLine("\n");
            // g. Close the Cinema.
            C1.CloseCinema();

        }
    }
}
