﻿using System;
using CrudCoreTest.Domain.CustomerAgg.Exceptions;

namespace CrudCoreTest.Domain.CustomerAgg
{
    public partial class Customer
    {
        public Customer(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email,
            int bankAccountNumber)
        {
  
            GuardAgainstEmptyPhoneNumber(phoneNumber);

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber.Trim();
            Email = email;
            BankAccountNumber = bankAccountNumber;
        }



        public Customer Update(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber,
            string email, int bankAccountNumber)
        {
          
            GuardAgainstEmptyPhoneNumber(phoneNumber);

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber.Trim();
            Email = email;
            BankAccountNumber = bankAccountNumber;
            return this;
        }

        private void GuardAgainstEmptyPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrWhiteSpace(phoneNumber))
                throw new InvalidPhoneNumberException("Enter your phone number");
        }
    }

}
