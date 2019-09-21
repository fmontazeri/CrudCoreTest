namespace CrudCoreTest.Domain.CustomerAgg.Exceptions
{
    public class InvalidPhoneNumberException : BusinessException 
    {
        public InvalidPhoneNumberException(string message) : base(message)
        {
        }
    }
}
