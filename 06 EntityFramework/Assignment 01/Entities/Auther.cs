using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01.Entities
{
    internal class Auther
    {
        public int AutherId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Biography { get; set; }

        public DateTime DateOfBirh { get; set; }

        public Auther(string firstName, string lastName, string email, string biography, DateTime dateOfBirh)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Biography = biography;
            DateOfBirh = dateOfBirh;
        }
    }
}
