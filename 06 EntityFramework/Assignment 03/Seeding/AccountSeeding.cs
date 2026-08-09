using Assignment_03.Enums;
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class AccountSeeding 
    {
        public List<Account> GenerateDate(List<Branch> _branches)
        {
            var accounts = new List<Account>()
            {
                new Account
                {
                    //AccountNumber = 1001,
                    AccountType = AccountType.Savings,
                    OpeningDate = new DateTime(2022, 1, 15),
                    CurrentBalance = 15000.50m,
                    Branch = _branches[0]
                },
                new Account
                {
                    //AccountNumber = 1002,
                    AccountType = AccountType.Current,
                    OpeningDate = new DateTime(2021, 5, 20),
                    CurrentBalance = 45000.75m,
                    Branch = _branches[1]
                },
                new Account
                {
                    //AccountNumber = 1003,
                    AccountType = AccountType.Business,
                    OpeningDate = new DateTime(2020, 3, 10),
                    CurrentBalance = 125000.00m,
                    Branch = _branches[0]
                },
                new Account
                {
                    //AccountNumber = 1004,
                    AccountType = AccountType.Savings,
                    OpeningDate = new DateTime(2023, 2, 8),
                    CurrentBalance = 8500.25m,
                    Branch = _branches[2]
                },
                new Account
                {
                    //AccountNumber = 1005,
                    AccountType = AccountType.Current,
                    OpeningDate = new DateTime(2022, 7, 12),
                    CurrentBalance = 32000.60m,
                    Branch = _branches[1]
                },
                new Account
                {
                    //AccountNumber = 1006,
                    AccountType = AccountType.Savings,
                    OpeningDate = new DateTime(2021, 9, 5),
                    CurrentBalance = 22500.40m,
                    Branch = _branches[0]
                },
                new Account
                {
                    //AccountNumber = 1007,
                    AccountType = AccountType.Business,
                    OpeningDate = new DateTime(2020, 11, 18),
                    CurrentBalance = 250000.00m,
                    Branch = _branches[1]
                }
            };

            return accounts;
        }
    }
}
