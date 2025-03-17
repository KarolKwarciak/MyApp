using System;
namespace EShop.Domain.Exceptions;
// Definiowanie własnego wyjątku
public class CardNumberTooLongException : Exception
{
    public CardNumberTooLongException() { }

    public CardNumberTooLongException(string message) : base(message) { }

    public CardNumberTooLongException(string message, Exception innerException) : base(message, innerException) { }
}

