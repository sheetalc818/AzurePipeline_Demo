using System;

namespace Facebook_beta_testing.ExceptionHandeling
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            NULL_VALUE, EMPTY_STRING_EXCEPTION
        }
        public ExceptionType exceptionType;

        public CustomExceptions(string message, ExceptionType exceptionType) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
