using System;
using System.ComponentModel.DataAnnotations;
using PhoneNumbers;

namespace FatemehMontazeriCrudCoreTest.Presentation.CustomeAttribute
{
    public class CheckPhoneNumberAttribute : ValidationAttribute
    {
        public string AllowRegion { get; set; }
        protected override ValidationResult IsValid(object phoneNumber, ValidationContext validationContext)
        {
            String numberStr = (string)phoneNumber;
            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            try
            {
                PhoneNumber parsedNumber = phoneUtil.Parse(numberStr, AllowRegion);
                return ValidationResult.Success;
            }
            catch (NumberParseException e)
            {
                return new ValidationResult("Enter your phone number");
            }
  }
    }
}