using Microsoft.EntityFrameworkCore;
using System;

namespace Lab3.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
            );

            modelBuilder.Entity<Contact>().HasData(
               new Contact { 
                   ContactId = 1, 
                   FirstName = "Bruce",
                   LastName = "Wayne",
                   Phone = "416-123-4567",
                   Email = "bruce.wayne@domain.com",
                   CategoryId = 1,
                   DateAdded = DateTime.Now
               },

                new Contact
                {
                    ContactId = 2,
                    FirstName = "Peter",
                    LastName = "Parker",
                    Phone = "647-123-4567",
                    Email = "peter.parker@gmail.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },

                 new Contact
                 {
                     ContactId = 3,
                     FirstName = "Bruce",
                     LastName = "Banner",
                     Phone = "905-123-4567",
                     Email = "bruce.banner@hotmail.com",
                     CategoryId = 3,
                     DateAdded = DateTime.Now
                 }
            );

        }

    }
}
