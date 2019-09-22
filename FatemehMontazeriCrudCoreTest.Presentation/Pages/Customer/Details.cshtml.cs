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
    public class DetailsModel : PageModel
    {
        private readonly ICustomerRepository customerRepository;

        public DetailsModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public CrudCoreTest.Domain.CustomerAgg.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await customerRepository.GetById(id.Value);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
