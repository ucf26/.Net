using Assignment_02.Configurations;
using Assignment_02.Entities;
using Assignment_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_02.Data
{
    internal class EventHubDbContext : DbContext
    {
        public DbSet<Registration> Registerations { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new RegistrationConfiguration());
            //modelBuilder.ApplyConfiguration(new EventConfiguration());
        }

    }
}
