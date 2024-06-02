using System.Text.RegularExpressions;
using Leashar.Domain.Shared;


namespace Leashar.Domain.Common.ValueObjects;

public partial class UserName : ValueObject
{
    public string Value { get; }
    
    private UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("User name cannot be empty", nameof(value));
        }
        
        if (!UserNameRegex().IsMatch(value))
        {
            throw new ArgumentException("User name is invalid", nameof(value));
        }
        Value = value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static UserName Create(string value)
    {
        return new UserName(value);
    }
    
    [GeneratedRegex(@"^(?=[a-zA-Z0-9._]{5,20}$)(?!.*[_.]{2})[^_.].*[^_.]$")]
    private static partial Regex UserNameRegex();
    
    public static Regex GetUserNameRegex() => UserNameRegex();
}