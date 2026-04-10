using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class VIPTicket : Ticket
    {
        private bool _loungeAccess;
        public bool LoungeAccess
        {
            get
            {
                return _loungeAccess;
            }
        }

        private decimal _serviceFee;
        public decimal ServiceFee
        {
            get { return _serviceFee; }
        }
        public VIPTicket(string moviename, decimal price, bool loungaccess, decimal servicefee) :
            base(moviename, price)
        {
            _loungeAccess = loungaccess;
            _serviceFee = servicefee;
            SetPrice(base.Price + _serviceFee);
        }

        public override void PrintTicket()
        {
            Console.WriteLine( $"Ticket ID : {base.TicketId}, Type: VIP, Movie:{base.MovieName}, Price: {base.Price:C}, Price after tax: {PriceAfterTax:C}, LoungeAccess: {(_loungeAccess == true ? "Yes": "No")}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Lounge Access: {_loungeAccess}, Service Fee: {_serviceFee:C}";
        }


    }
}
