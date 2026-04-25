using Movie_Ticket_Booking_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal static class BookingHelper
    {
        static int counter = 0;

        // returns total price with a 10% discount if the group has 5 or more tickets, otherwise returns the full total.
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double ans = 0;

            if (numberOfTickets >= 5)
            {
                ans = numberOfTickets * pricePerTicket * 0.9; 
            }
            else
            {
                ans = numberOfTickets * pricePerTicket;
            }

            return ans;
        }

        // That returns a unique string each time it is called (e.g., "BK-1", "BK-2", "BK-3", ...). Use a private static counter internally.
        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}";
        }

        public static void Print(IPrintable obj)
        {
            obj.Print();
        } 




    }
}
