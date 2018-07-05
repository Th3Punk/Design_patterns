using Microsoft.EntityFrameworkCore;
using System;


namespace _00Data
{
    public class AddressContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=./punkserver; Database=test; Trusted_Connection=True;"
                );
        }

        public DbSet<MyAddress> MyAddress { get; set; }
    }
}
