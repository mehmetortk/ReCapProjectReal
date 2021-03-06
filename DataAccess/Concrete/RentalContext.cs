using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class RentalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=CarRental; Trusted_Connection=true");
        }

            public DbSet<Brand> Brands { get; set; }
           public DbSet<Color> Colors { get; set; }
           public DbSet<Car> Cars { get; set; }
           public DbSet<Rental> Rentals { get; set; }
           public DbSet<User> Users { get; set; }
           public DbSet<Customer> Customers { get; set; }



    }
}

