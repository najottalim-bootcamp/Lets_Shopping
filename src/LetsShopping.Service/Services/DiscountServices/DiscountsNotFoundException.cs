using System.Runtime.Serialization;

namespace LetsShopping.Service.Services.DiscountServices
{
    [Serializable]
    internal class DiscountsNotFoundException : Exception
    {
        public DiscountsNotFoundException()
        {
        }

        public DiscountsNotFoundException(string? message) : base(message)
        {
        }

        public DiscountsNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DiscountsNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}