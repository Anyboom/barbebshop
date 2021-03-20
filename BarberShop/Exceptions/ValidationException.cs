using System;

namespace BarberShop
{
    [Serializable]
    internal class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}
