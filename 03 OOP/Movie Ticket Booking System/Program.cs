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

            C1.AddTicket(T1);
            C1.AddTicket(T2);
            C1.AddTicket(T3);

            // c.Print all tickets through the Cinema.

            C1.PrintAllTickets();

            
        }
    }
}
