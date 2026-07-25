using Assignment_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(e => e.EventId);

            builder.Property(e => e.Title)
                   .IsRequired(true)
                   .HasMaxLength(100);

            builder.Property(e => e.Description)
                   .IsRequired(false)
                   .HasMaxLength(250);

            builder.Property(e => e.StartDate)
                   .IsRequired(true)
                   .HasDefaultValueSql("GetDate()");

            builder.Property(e => e.EndDate)
                   .IsRequired(false);

            builder.Property(e => e.MaxAttendees)
                   .IsRequired(true)
                   .HasDefaultValueSql("100");

            builder.HasOne(e => e.Organizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OrganizerId);

            builder.HasOne(e => e.ParentEvent)
                   .WithMany(parent => parent.ChildEvents)
                   .HasForeignKey(e => e.ParentEventId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
