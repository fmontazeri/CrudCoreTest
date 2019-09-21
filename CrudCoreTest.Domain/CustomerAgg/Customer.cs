using System;

namespace CrudCoreTest.Domain.CustomerAgg
{
    public partial class Customer
    {
        protected Customer()
        {
        }

        public long Id { get; private set; }
        public string FirstName { get; private set; }
        public  string  LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public int  BankAccountNumber { get; private set; }
    }
}
