using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Configurations
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasMany(a => a.Transactions)
                   .WithOne(t => t.Account)
                   .HasForeignKey(a => a.AccountNumber);


            builder.HasOne(a => a.Branch)
                   .WithMany(b => b.Accounts)
                   .HasForeignKey(a => a.BranchCode);

            builder.HasMany(a => a.CustomerAccounts)
                   .WithOne(CA => CA.Account)
                   .HasForeignKey(a => a.AccountNumber);
        }
    }
}
