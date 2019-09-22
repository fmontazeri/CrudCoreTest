using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudCoreTest.Domain.CustomerAgg;
using FatemehMontazeriCrudCoreTest.Presentation.Models;
using FatemehMontazeriCrudCoreTest.Presentation.ExtenstionMethods;

namespace FatemehMontazeriCrudCoreTest.Presentation.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly ICustomerRepository customerRepository;

        public CreateModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }



        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CreateCustomerModel Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var customer = new CrudCoreTest.Domain.CustomerAgg.Customer(Customer.FirstName, Customer.LastName,
                    Customer.DateOfBirth.ToDateTime(), Customer.PhoneNumber, Customer.Email, Customer.BankAccountNumber);
                await customerRepository.Add(customer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return Page();
            }
      

            return RedirectToPage("./Index");
        }
    }
}