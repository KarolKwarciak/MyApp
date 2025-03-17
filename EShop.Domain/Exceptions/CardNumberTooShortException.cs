using System;
namespace EShop.Domain.Exceptions;

// Definiowanie własnego wyjątku
public class CardNumberTooShortException : Exception
{
    public CardNumberTooShortException() { }

    public CardNumberTooShortException(string message) : base(message) { }

    public CardNumberTooShortException(string message, Exception innerException) : base(message, innerException) { }
}