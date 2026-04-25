using Movie_Ticket_Booking_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class VIPTicket : Ticket, IPrintable
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

        public void Print()
        {
            Console.WriteLine( $"Ticket ID : {base.TicketId}, Type: VIP, Booking Status: {base.Status}, Movie:{base.MovieName}, Price: {base.Price:C}, Price after tax: {PriceAfterTax:C}, LoungeAccess: {(_loungeAccess == true ? "Yes": "No")}");
        }

        public object Clone()
        {
            return new VIPTicket(MovieName, Price - _serviceFee, _loungeAccess, _serviceFee );
        }
        public override string ToString()
        {
            return base.ToString() + $", Lounge Access: {_loungeAccess}, Service Fee: {_serviceFee:C}";
        }


    }
}
