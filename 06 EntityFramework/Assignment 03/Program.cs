using Assignment_03.Date;
using Assignment_03.Models;
using Assignment_03.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var AppContext = new Context())
            {
                AppContext.Database.Migrate();


                var BranchsData = new BranchSeeding();
                var branchs = BranchsData.GenerateDate();

                var ManagersData = new ManagerSeeding();
                var managers = ManagersData.GenerateDate(branchs);


                var CustomersData = new CustomerSeeding();
                var customers = CustomersData.GenerateDate();

                var AccountsData = new AccountSeeding();
                var accounts = AccountsData.GenerateDate(branchs);

                var CustomerAccountsData = new CustomerAccountSeeding();
                var CustomerAccounts = CustomerAccountsData.GenerateDate(customers, accounts);

                var TransactionsData = new TransactionSeeding();
                var Transactions = TransactionsData.GenerateDate(accounts);

                if (!AppContext.Managers.Any())
                {
                    AppContext.Managers.AddRange(managers);
                }
                if (!AppContext.Branches.Any())
                {
                    AppContext.Branches.AddRange(branchs);
                }
                if (!AppContext.Customers.Any())
                {   
                    AppContext.Customers.AddRange(customers);
                }
                if (!AppContext.Accounts.Any())
                {
                    AppContext.Accounts.AddRange(accounts);
                }
                if (!AppContext.CustomerAccounts.Any())
                {
                    AppContext.CustomerAccounts.AddRange(CustomerAccounts);
                }
                if (!AppContext.Transactions.Any())
                {
                    AppContext.Transactions.AddRange(Transactions);
                }
                AppContext.SaveChanges();
            }
            



        }
    }
}
