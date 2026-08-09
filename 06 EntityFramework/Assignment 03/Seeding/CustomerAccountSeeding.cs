using Assignment_03.Enums;
using Assignment_03.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Seeding
{
    internal class CustomerAccountSeeding 
    {

        public List<CustomerAccount> GenerateDate(List<Customer> customers, List<Account>accounts)
        {
            var customerAccounts = new List<CustomerAccount>
            {
                new CustomerAccount
                {
                    Customer = customers[0],
                    Account = accounts[6],
                    OwnershipStartDate = new DateTime(2022, 1, 15),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[2],
                    Account = accounts[0],
                    OwnershipStartDate = new DateTime(2021, 5, 20),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[1],
                    Account = accounts[1],
                    OwnershipStartDate = new DateTime(2020, 3, 10),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[3],
                    Account = accounts[5],
                    OwnershipStartDate = new DateTime(2023, 2, 8),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[1],
                    Account = accounts[4],
                    OwnershipStartDate = new DateTime(2022, 7, 12),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[4],
                    Account = accounts[3],
                    OwnershipStartDate = new DateTime(2021, 9, 5),
                    AccountStatus = AccountStatus.Active,
                    OwnershipType = OwnershipType.P
                },
                new CustomerAccount
                {
                    Customer = customers[3],
                    Account = accounts[1],
                    OwnershipStartDate = new DateTime(2020, 11, 18),
                    AccountStatus = AccountStatus.Closed,
                    OwnershipType = OwnershipType.P
                }
            };

            return customerAccounts;
        }
    }
}
