using System.Net;

namespace LetsShopping.Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string TitleMessage { get; set; } = string.Empty;
    }
}
