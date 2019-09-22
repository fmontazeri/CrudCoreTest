using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudCoreTest.Data.Context;
using CrudCoreTest.Domain.CustomerAgg;
using FatemehMontazeriCrudCoreTest.Presentation.ExtenstionMethods;
using FatemehMontazeriCrudCoreTest.Presentation.Models;

namespace FatemehMontazeriCrudCoreTest.Presentation.Pages.Customer
{
    public class DeleteModel : PageModel
    {
        private readonly ICustomerRepository customerRepository;

        public DeleteModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }


        [BindProperty]
        public CustomerModel Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await customerRepository.GetById(id.Value);
            Customer = new CustomerModel(){FirstName =  customer.FirstName , LastName = customer.LastName ,BankAccountNumber = customer.BankAccountNumber , DateOfBirth = customer.DateOfBirth.ToString(), Email = customer.Email , PhoneNumber = customer.PhoneNumber , Id = customer.Id};

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await customerRepository.GetById(id.Value);
            if (customer == null) return NotFound();
            try
            {
                await customerRepository.Delete(customer);
            }
            catch (Exception ex)
            {
                Customer = new CustomerModel(){FirstName = customer.FirstName , LastName = customer.LastName ,BankAccountNumber = customer.BankAccountNumber ,DateOfBirth = customer.DateOfBirth.ToStringFormat() , Email = customer.Email , PhoneNumber = customer.PhoneNumber};
                ModelState.AddModelError("Error",ex.InnerException!= null? ex.InnerException.Message : ex.Message);
                return Page();
            }
         

            return RedirectToPage("./Index");
        }
    }
}
