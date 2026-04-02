
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    // made it static assuming that the cinema has only one hall with one projector 
    internal static class Projector
    {
        public static void StartProjector()
        {
            Console.WriteLine("\t\t\t\t***********************************************************");
            Console.WriteLine("\t\t\t\t*                                                         *");
            Console.WriteLine("\t\t\t\t*                   Projector Started !                   *");
            Console.WriteLine("\t\t\t\t*                                                         *");
            Console.WriteLine("\t\t\t\t***********************************************************");

        }

        public static void CloseProjector()
        {
            Console.WriteLine("\t\t\t\t***********************************************************");
            Console.WriteLine("\t\t\t\t*                                                         *");
            Console.WriteLine("\t\t\t\t*                   Projector Closed !                   *");
            Console.WriteLine("\t\t\t\t*                                                         *");
            Console.WriteLine("\t\t\t\t***********************************************************");

        }




    }
}
