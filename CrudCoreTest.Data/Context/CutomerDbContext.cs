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
        public CutomerDbContext(DbContextOptions<CutomerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
