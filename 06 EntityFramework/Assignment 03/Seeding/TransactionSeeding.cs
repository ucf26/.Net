
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class TransactionSeeding
    {
        public List<Transaction> GenerateDate(List<Account> accounts)
        {
            var transactions = new List<Transaction>
            {
                new Transaction
                {
                    //TransactionNumber = 5001,
                    TransactionDate = new DateTime(2024, 1, 10, 9, 30, 0),
                    Amount = 500.00m,
                    Description = "Salary Deposit",
                    TransactionType = "Deposit",
                    Account = accounts[0]
                },
                new Transaction
                {
                    //TransactionNumber = 5002,
                    TransactionDate = new DateTime(2024, 1, 12, 14, 15, 0),
                    Amount = 200.00m,
                    Description = "Grocery Shopping",
                    TransactionType = "Withdrawal",
                    Account = accounts[1]
                },
                new Transaction
                {
                    //TransactionNumber = 5003,
                    TransactionDate = new DateTime(2024, 1, 15, 11, 45, 0),
                    Amount = 1000.00m,
                    Description = "Transfer to Account 1002",
                    TransactionType = "Transfer",
                    Account = accounts[3]
                },
                new Transaction
                {
                    //TransactionNumber = 5004,
                    TransactionDate = new DateTime(2024, 1, 18, 10, 20, 0),
                    Amount = 5000.00m,
                    Description = "Business Invoice Payment",
                    TransactionType = "Payment",
                    Account = accounts[5]
                },
                new Transaction
                {
                    //TransactionNumber = 5005,
                    TransactionDate = new DateTime(2024, 1, 20, 16, 0, 0),
                    Amount = 250.00m,
                    Description = "ATM Withdrawal",
                    TransactionType = "Withdrawal",
                    Account = accounts[4]
                },
                new Transaction
                {
                    //TransactionNumber = 5006,
                    TransactionDate = new DateTime(2024, 1, 22, 13, 30, 0),
                    Amount = 1500.00m,
                    Description = "Monthly Utility Bill",
                    TransactionType = "Payment",
                    Account = accounts[6]
                },
                new Transaction
                {
                    //TransactionNumber = 5007,
                    TransactionDate = new DateTime(2024, 1, 25, 9, 0, 0),
                    Amount = 300.00m,
                    Description = "Interest Credit",
                    TransactionType = "Deposit",
                    Account = accounts[5]
                },
                new Transaction
                {
                    //TransactionNumber = 5008,
                    TransactionDate = new DateTime(2024, 1, 27, 15, 45, 0),
                    Amount = 10000.00m,
                    Description = "Business Expense Reimbursement",
                    TransactionType = "Deposit",
                    Account = accounts[1]
                }
            };

            return transactions;
        }
    }
}
