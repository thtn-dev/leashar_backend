using System.Text.RegularExpressions;
using ErrorOr;
using Leashar.Domain.Common.Exceptions;
using Leashar.Domain.Shared;

namespace Leashar.Domain.Common.ValueObjects;

public partial class Email : ValueObject
{
    public string Value { get; }
    private Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Email address cannot be empty", nameof(value));
        }
        
        if (!EmailRegex().IsMatch(value))
        {
            throw new ArgumentException("Email address is invalid", nameof(value));
        }
        
        Value = value;
    }
    
    public static Email Create(string email)
    {
        return new Email(email);
    }

    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    [GeneratedRegex(@"^[\w\-\.]+@([\w-]+\.)+[\w-]{2,}$")]
    private static partial Regex EmailRegex();

    public Regex GetEmailRegex() => EmailRegex();

}