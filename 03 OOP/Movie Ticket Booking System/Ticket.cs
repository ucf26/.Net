using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        private string? _movieName;
        private TicketType _ticketType;
        private SeatLocation  _seat;
        private double _price;
        private double _discountAmount;
        private static int _totalCount=0;
        private static int _ticketId;

        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _movieName = value;
                }else
                {
                    Console.WriteLine("MovieNam cann't be null or empty.");
                }
            }
        }

        public TicketType TicketType {
            get
            {
                return _ticketType;
            }
            set
            {
                _ticketType = value; 
            }
        }

        public SeatLocation _seatLocation
        {
            get
            {
                return _seatLocation;
            }
            set
            {
                _seatLocation = value;
            }
        }

        public double Price {
            get
            {
                return _price;
            }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price must b greater than zero.");
                }
            }
        }

        public double PriceAfterTax
        {
            get
            {
                return _price * 1.14;
            }
        }


        public Ticket(string? moviename, TicketType type, char _seatRow,int _seatNumber, double price, double discountamount)
        {
            _movieName = moviename;
            _ticketType = type;
            _seat = new SeatLocation (_seatRow, _seatNumber);
            _price = price;
            _discountAmount = discountamount;
            _totalCount++;
            _ticketId = _totalCount;
        }

        public Ticket(string? moviename) : this(moviename, TicketType.Standard, 'A', 15, 50, 0)
        {

        }

        public double CalcTotal(double taxPrcent)
        {
            return _price * (1+(taxPrcent/100));
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if(discountAmount > 0 && discountAmount >= _price)
            {
                _price =_price -  discountAmount;
                discountAmount = 0;
            }
        }


        public static int GetTotalTicketsSold()
        {
            return _totalCount;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"\t==== Ticket Info ====");
            Console.WriteLine($"\tMovie:     {_movieName}");
            Console.WriteLine($"\t_ticketType:      {_ticketType}");
            Console.WriteLine($"\tSeatLocation :      {_seat}");
            Console.WriteLine($"\t_price:     {_price}");
            Console.WriteLine($"\tTotal (14% tax): {CalcTotal(14).ToString("F2")}");
        }

        public void PrintAfterDiscount()
        {
            Console.WriteLine($"===== After Discount =====");
            Console.WriteLine($"Discount Before: {_discountAmount}");

            Console.WriteLine($"Discount After: {_discountAmount}");
        }
    }


    enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }

    struct SeatLocation
    {
        public char Row;
        public int Number;

        public SeatLocation (char row, int number)
        {
            Row = char.ToUpper(row);
            Number = number;
        }

        public override string ToString()
        {
            return $"({Row}{Number})";
        }
    }
}
