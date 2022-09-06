using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NEW_BATCH1_DET_2022.Data.BookContext;
using NEW_BATCH1_DET_2022.Models;

namespace NEW_BATCH1_DET_2022.Data
{
    
        public class BookContext : DbContext
        {
            public BookContext() { }


            public BookContext(DbContextOptions<BookContext> options) : base(options)
            { }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {

                    optionsBuilder.UseSqlServer("Server=H985T72-SHEL\\SQLEXPRESS;Database=tsql_training;Trusted_Connection=True;MultipleActiveResultSets=True");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Book>()
                    .Property(b => b.price)
                    .IsRequired()
                    .HasColumnName("BKprice")
                    .HasDefaultValue(200);
            }

        public static void Main()
        {

        }
        } 
}

