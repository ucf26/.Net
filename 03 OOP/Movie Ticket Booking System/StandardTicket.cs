using Movie_Ticket_Booking_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class StandardTicket:Ticket, IPrintable
    {
        private string? _seatNumber;

        public string? SeatNumber
        {
            get { return _seatNumber; }
            set { _seatNumber = value; }
        }

        public StandardTicket(string movieName, decimal price, string? seatNumber) : base(movieName, price)
        {
            _seatNumber = seatNumber;
        }

        public void Print()
        {
            Console.WriteLine($"Ticket ID : {base.TicketId}, Type: Standard, Booking Status: {base.Status}, Movie:{base.MovieName}, Price: {base.Price:C}, Price after tax: {PriceAfterTax:C}, Seat Number: {_seatNumber}");
        }

        public object Clone()
        {
            return new StandardTicket(MovieName, Price, _seatNumber);
        }

        public override string ToString()
        {
            return base.ToString() + $", Seat Number: {_seatNumber}";
        }

    }
}
