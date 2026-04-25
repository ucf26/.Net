using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System.Interfaces
{
    public enum BookingStatus
    {
        Available,
        Booked,
        Cancelled
    }
    internal interface IBookable
    {
        public BookingStatus Status { get;}

        bool Book();

        bool Cancel();
    }
}
