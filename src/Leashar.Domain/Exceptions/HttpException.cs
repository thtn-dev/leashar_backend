using System.Net;
using System.Runtime.Serialization;

namespace Leashar.Domain.Exceptions;
[Serializable]
public class HttpException : Exception
{
    public HttpStatusCode StatusCode { get; set; }
    public HttpException(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
    public HttpException(HttpStatusCode statusCode, string message, Exception inner) : base(message, inner)
    {
        StatusCode = statusCode;
    }
}