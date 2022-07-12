using LearnCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LearnCodeFirstApproach.Data
{
    public class BookContext : DbContext
    {
        public BookContext()
        {

        }
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Book> Books { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<JoinedTable> JoinTables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BG4WS1346\\SQLEXPRESS;Database=akshay;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PropertyConfiguration

            modelBuilder.Entity<Book>().Property(b =>b.BookAge).IsRequired() //[Required]
                .HasColumnName("Book_Age") //[Column("Book_Age")
                .HasDefaultValue(2);

            modelBuilder.Entity<JoinedTable>(entity =>
            {
                entity.HasNoKey();

              
            });
        }

    }
}

