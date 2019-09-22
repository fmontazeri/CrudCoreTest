using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudCoreTest.Domain.CustomerAgg
{
   public interface ICustomerRepository
   {
       Task<Customer> GetById(long id);
       Task<IList<Customer>> GetAll();
       Task Add(Customer customer);
       Task Update(Customer customer);
       Task Delete(Customer customer);
   }
}
