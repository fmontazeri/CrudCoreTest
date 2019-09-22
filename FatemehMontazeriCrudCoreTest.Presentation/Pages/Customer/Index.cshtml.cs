using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudCoreTest.Data.Context;
using CrudCoreTest.Domain.CustomerAgg;

namespace FatemehMontazeriCrudCoreTest.Presentation.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerRepository customerRepository;

        public IndexModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public IList<CrudCoreTest.Domain.CustomerAgg.Customer> Customers { get;set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {

            Customers = await customerRepository.GetAll();
            return Page();
        }
    }
}
