namespace Movie_Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // a. Create a Cinema and open it.
            Cinema C1 = new Cinema();

            C1.OpenCinema();


            // b.Create one of each ticket type (hardcoded data) and add them to the Cinema.

            VIPTicket T1 = new VIPTicket("Inception", 15.00m, true, 50);
            IMAXTicket T2 = new IMAXTicket("Avatar", 12.00m, true);
            StandardTicket T3 = new StandardTicket("The Matrix", 10.00m, "A-5");



            // c. Test both versions of SetPrice on one ticket.

            T1.SetPrice(20.00m);
            T2.SetPrice(20.00m, 5.00m);


            // d. Add all tickets to the Cinema and call PrintAllTickets().

            C1.AddTicket(T1);
            C1.AddTicket(T2);
            C1.AddTicket(T3);

            C1.PrintAllTickets();

            // e. Call ProcessTicket() with one of the tickets.
            Console.WriteLine("\n\n\tProcessing Ticket.....!\n");

            Cinema.ProcessTicket(T1);


            // f. Close the Cinema.
            C1.CloseCinema();

        }
    }
}
