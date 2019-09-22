using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCoreTest.Data.Context;
using CrudCoreTest.Domain.CustomerAgg;
using Microsoft.EntityFrameworkCore;

namespace CrudCoreTest.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext dbContext;

        public CustomerRepository(CustomerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public  Task<Customer> GetById(long id)
        {
            return  dbContext.Customers.FindAsync(id);
        }

        public async Task<IList<Customer>> GetAll()
        {
            return await dbContext.Customers.ToListAsync();
        }

        public async Task Add(Customer customer)
        {
           await dbContext.Customers.AddAsync(customer);
           await dbContext.SaveChangesAsync();
        }

        public async Task Update(Customer customer)
        {
           dbContext.Customers.Update(customer);
           await dbContext.SaveChangesAsync();
            
        }

        public async  Task Delete(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            await  dbContext.SaveChangesAsync();
        }

    }
}
