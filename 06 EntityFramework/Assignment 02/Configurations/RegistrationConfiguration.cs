using Assignment_02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;   
using System;
using System.Collections.Generic;
using System.Text;
    
namespace Assignment_02.Configurations
{
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registrations");

            builder.HasKey(r => new { r.EventId, r.AttendeeId });

            builder.HasOne(r => r.Attendee)
                   .WithMany(a => a.Registrations)
                   .HasForeignKey(r => r.AttendeeId);

            builder.HasOne(r => r.Event)
                    .WithMany(e => e.Registrations)
                    .HasForeignKey(r => r.EventId);

            builder.Property(r => r.Note)
                   .HasMaxLength(50);
        }
    }
}
