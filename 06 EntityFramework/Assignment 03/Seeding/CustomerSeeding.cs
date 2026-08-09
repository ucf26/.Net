
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class CustomerSeeding
    {
        public List<Customer> GenerateDate()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    //Id = 1,
                    FullName = "Omar Mostafa",
                    DateOfBirth = new DateTime(1985, 5, 12),
                    NationalId = 123456789,
                    EmailAddress = "omar.mostafa@email.com",
                    PhoneNumber = 31234567,
                    HomeAddress = "12 Nile Street, Cairo"
                },
                new Customer
                {
                    //Id = 2,
                    FullName = "Leila Sabry",
                    DateOfBirth = new DateTime(1990, 8, 25),
                    NationalId = 987654321,
                    EmailAddress = "leila.sabry@email.com",
                    PhoneNumber = 32345678,
                    HomeAddress = "34 Giza Avenue, Giza"
                },
                new Customer
                {
                    //Id = 3,
                    FullName = "Amira Khalil",
                    DateOfBirth = new DateTime(1988, 3, 18),
                    NationalId = 456789123,
                    EmailAddress = "amira.khalil@email.com",
                    PhoneNumber = 30346789,
                    HomeAddress = "56 Cairo Road, Cairo"
                },
                new Customer
                {
                    //Id = 4,
                    FullName = "Karim Nasser",
                    DateOfBirth = new DateTime(1992, 11, 7),
                    NationalId = 321654987,
                    EmailAddress = "karim.nasser@email.com",
                    PhoneNumber = 34567890,
                    HomeAddress = "78 Heliopolis Lane, Cairo"
                },
                new Customer
                {
                    //Id = 5,
                    FullName = "Hana Rashid",
                    DateOfBirth = new DateTime(1987, 7, 30),
                    NationalId = 654987321,
                    EmailAddress = "hana.rashid@email.com",
                    PhoneNumber = 35678901,
                    HomeAddress = "90 Ahmed Maher Street, Giza"
                }
            };
            return customers;
        }
    }
}
