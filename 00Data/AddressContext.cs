using System;
using System.Data.Entity;

namespace _00Data
{
    public class AddressContext : DbContext
    {
        public DbSet<MyAddress> MyAddress { get; set; }
    }
}
