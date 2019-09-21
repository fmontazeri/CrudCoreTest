using System;
using System.Collections.Generic;
using System.Text;
using CrudCoreTest.Data.Configuratins.CustomerAgg;
using CrudCoreTest.Domain.CustomerAgg;
using Microsoft.EntityFrameworkCore;

namespace CrudCoreTest.Data.Context
{
    public  class CutomerDbContext : DbContext
    {
        public CutomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MONTAZERI-PC\SQLDEV;Initial Catalog=FatemehMontazeriCoreDb;User Id=sa;Password=1404;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
