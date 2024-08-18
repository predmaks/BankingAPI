namespace Banking.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public string Details { get; }

        public ValidationException(string message) : base(message)
        {
        }

        public ValidationException(string message, string details) : base(message)
        {
            Details = details;
        }
    }
}
