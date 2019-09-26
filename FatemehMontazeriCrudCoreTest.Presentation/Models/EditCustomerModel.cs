using System.ComponentModel.DataAnnotations;
using FatemehMontazeriCrudCoreTest.Presentation.CustomeAttribute;

namespace FatemehMontazeriCrudCoreTest.Presentation.Models
{
    public class EditCustomerModel
    {
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        [CheckPhoneNumber(AllowRegion = "IR", ErrorMessage = ("Enter your phone number in correct format"))]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int BankAccountNumber { get; set; }
    }
}