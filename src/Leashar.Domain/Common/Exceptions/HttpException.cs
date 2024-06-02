using System.Net;
using System.Runtime.Serialization;

namespace Leashar.Domain.Common.Exceptions;
[Serializable]
public class HttpException : Exception
{
    public HttpStatusCode StatusCode { get; set; }
    public List<string> Errors { get; set; }
    public HttpException(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
        Errors = new List<string> { message };
    }
    public HttpException(HttpStatusCode statusCode, string message, Exception inner) : base(message, inner)
    {
        StatusCode = statusCode;
        Errors = new List<string> { message };
    }
    
    public HttpException(HttpStatusCode statusCode, List<string> errors) : base(string.Join(",", errors))
    {
        StatusCode = statusCode;
        Errors = errors;
    }
}