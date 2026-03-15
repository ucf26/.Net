using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        public string? MovieName;
        public Type Type;
        //public char SeatRow;
        //public int SeatNumber;
        public Seat seat;
        private double Price;
        private double DiscountAmount;

        public Ticket(string? moviename, Type type, char seatRow,int seatNumber, double price, double discountamount)
        {
            MovieName = moviename;
            Type = type;
            //SeatRow = seatRow;
            //SeatNumber = seatNumber;
            seat = new Seat(seatRow, seatNumber);
            Price = price;
            DiscountAmount = discountamount;
        }

        public Ticket(string? moviename) : this(moviename,Type.Standard, 'A', 15, 50, 0)
        {

        }

        public double CalcTotal(double taxPrcent)
        {
            return Price * (1+(taxPrcent/100));
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if(discountAmount > 0 && discountAmount >= Price)
            {
                Price =Price -  discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine("==== Ticket Info ====");
            Console.WriteLine($"Movie:     {MovieName}");
            Console.WriteLine($"Type:      {Type}");
            Console.WriteLine($"Seat:      {seat}");
            Console.WriteLine($"Price:     {Price}");
            Console.WriteLine($"Total (14% tax): {CalcTotal(14)}");
        }
    }


    enum Type
    {
        Standard,
        VIP,
        IMAX
    }

    struct Seat
    {
        public char Row;
        public int Number;

        public Seat(char row, int number)
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
