
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class ManagerSeeding
    {
        public List<Manager> GenerateDate(List<Branch> _branches)
        {
            var managers = new List<Manager>
            {
                new Manager
                {
                    //Id = 1,
                    FullName = "Ahmed Hassan",
                    EmailAddress = "ahmed.hassan@bank.com",
                    PhoneNumber = 1001234567,
                    HireDate = new DateTime(2019, 3, 15),
                    Branch = _branches[0]

                },
                new Manager
                {
                    //Id = 2,
                    FullName = "Fatima Ali",
                    EmailAddress = "fatima.ali@bank.com",
                    PhoneNumber = 1002345678,
                    HireDate = new DateTime(2020, 6, 22),
                    Branch = _branches[1]
                },
                new Manager
                {
                    //Id = 3,
                    FullName = "Mohamed Karim",
                    EmailAddress = "mohamed.karim@bank.com",
                    PhoneNumber = 1003456789,
                    HireDate = new DateTime(2018, 1, 10),
                    Branch = _branches[2]
                }
            };
            return managers;
        }
    }
}
