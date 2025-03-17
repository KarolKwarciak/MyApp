using System;
namespace EShop.Domain.Exceptions;

// Definiowanie własnego wyjątku
public class CardNumberInvalidException : Exception
{
    public CardNumberInvalidException() { }

    public CardNumberInvalidException(string message) : base(message) { }

    public CardNumberInvalidException(string message, Exception innerException) : base(message, innerException) { }
}