using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Context
{
    internal class ApplicationDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            //modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DbCoffeeShop; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
