using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03.Configurations
{
    internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasOne(m=>m.Branch)
                   .WithOne(b=>b.Manager)
                   .HasForeignKey<Manager>(m=>m.BranchCode);
        }
    }
}
