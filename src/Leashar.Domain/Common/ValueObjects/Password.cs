using Leashar.Domain.Shared;

namespace Leashar.Domain.Common.ValueObjects;

public class Password : ValueObject
{
    public string Value { get; private set; }
    
    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Password cannot be empty", nameof(value));
        }

        Value = value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}