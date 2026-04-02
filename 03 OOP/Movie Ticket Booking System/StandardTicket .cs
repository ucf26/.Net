using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class StandardTicket:Ticket
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

        public override string ToString()
        {
            return base.ToString() + $", Seat Number: {_seatNumber}";
        }

    }
}
