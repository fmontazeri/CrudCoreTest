using System.Collections.Generic;

namespace CrudCoreTest.Domain.CustomerAgg
{
   public interface ICustomerRepository
   {
       Customer GetById(long id);
       List<Customer> GetAll();
       void Add(Customer customer);
       void Update(Customer customer);
       void Delete(long id);
   }
}
