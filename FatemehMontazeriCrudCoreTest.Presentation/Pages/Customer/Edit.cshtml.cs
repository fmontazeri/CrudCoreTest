using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudCoreTest.Data.Context;
using CrudCoreTest.Domain.CustomerAgg;
using FatemehMontazeriCrudCoreTest.Presentation.ExtenstionMethods;
using FatemehMontazeriCrudCoreTest.Presentation.Models;

namespace FatemehMontazeriCrudCoreTest.Presentation.Pages.Customer
{
    public class EditModel : PageModel
    {
        private readonly ICustomerRepository customerRepository;

        public EditModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }


        [BindProperty]
        public EditCustomerModel Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer =  await customerRepository.GetById(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            Customer = new EditCustomerModel()
             {
                 FirstName =  customer.FirstName , LastName = customer.LastName , BankAccountNumber = customer.BankAccountNumber,
                 DateOfBirth = customer.DateOfBirth.ToStringFormat() , Email = customer.Email , Id = customer.Id,PhoneNumber = customer.PhoneNumber
             };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var customer =await customerRepository.GetById(Customer.Id);
            if (customer == null) return NotFound();
            
           try
            {
                customer.Update(Customer.FirstName, Customer.LastName, Customer.DateOfBirth.ToDateTime(),customer.PhoneNumber,
                    Customer.Email, Customer.BankAccountNumber);
                await customerRepository.Update(customer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error" , ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return Page();
            }

            return RedirectToPage("./Index");
        }

 
    }
}
