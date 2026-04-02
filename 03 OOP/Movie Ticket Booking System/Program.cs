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

            C1.AddTicket(T1);


            IMAXTicket T2 = new IMAXTicket("Avatar", 12.00m, true);

            C1.AddTicket(T2);

            StandardTicket T3 = new StandardTicket("The Matrix", 10.00m, "A-5");
            
            C1.AddTicket(T3);

            // Print all tickets.

            C1.PrintAllTickets();

            // d. Close the Cinema.
            C1.CloseCinema();

            C1.CloseCinema();


        }
    }
}
