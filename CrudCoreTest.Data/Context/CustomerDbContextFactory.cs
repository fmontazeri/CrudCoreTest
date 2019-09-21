using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CrudCoreTest.Data.Context
{
    public class CustomerDbContextFactory : IDesignTimeDbContextFactory<CutomerDbContext>
    {
        public CutomerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CutomerDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=MONTAZERI-PC\SQLDEV;Initial Catalog=FatemehMontazeriCoreDb;User Id=sa;Password=1404;");

            return new CutomerDbContext(optionsBuilder.Options);
        }
    }
}
