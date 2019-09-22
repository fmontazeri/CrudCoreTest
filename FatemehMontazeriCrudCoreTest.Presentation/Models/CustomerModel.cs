using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FatemehMontazeriCrudCoreTest.Presentation.Models
{
    public class CustomerModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int BankAccountNumber { get; set; }
    }
}
