using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class IMAXTicket: Ticket
    {
        private bool _is3D;
        public bool Is3D
        {
            get { return _is3D; } 
        }

        public IMAXTicket(string moviename, decimal price, bool is3d) : base(moviename, price)
        {
            _is3D = is3d;
            if (_is3D)
            {
                SetPrice(base.Price + 30);
            }
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket ID : {base.TicketId}, Type: IMAX, Movie:{base.MovieName}, Price: {base.Price:C}, Price after tax: {PriceAfterTax:C}, Is3D: {(_is3D ? "Yes" : "No")}");
        }

        public override string ToString()
        {
            return base.ToString() + $", 3D: {_is3D}";
        }
    }
}
