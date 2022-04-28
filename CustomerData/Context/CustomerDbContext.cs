using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerData.Models;

namespace CustomerData.Context
{
    public class CustomerDbContext : DbContext
    {
        private readonly string _connectionString;

        public CustomerDbContext() : this("Server=FLMBQG3;Database=CustomerDb;User Id=sa;Password=Manago@021295")
        {

        }

        public CustomerDbContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._connectionString);
            }
        }
    }
}
