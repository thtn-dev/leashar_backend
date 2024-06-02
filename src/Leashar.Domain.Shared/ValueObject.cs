namespace Leashar.Domain.Shared;
[Serializable]
public abstract  class ValueObject : IEquatable<ValueObject>
{
    private int? _cachedHashCode;
    protected abstract IEnumerable<object> GetEqualityComponents();

    public override int GetHashCode()
    {
        _cachedHashCode ??= GetEqualityComponents()
            .Aggregate(1, (current, obj) =>
            {
                unchecked
                {
                    return current * 23 + (obj?.GetHashCode() ?? 0);
                }
            });

        return _cachedHashCode.Value;
    }
    
    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }
        var other = (ValueObject)obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }
    
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public int CompareTo(ValueObject? other)
    {
        throw new NotImplementedException();
    }

    public bool Equals(ValueObject? other)
    {
        return other != null && GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }
    
    public static bool operator ==(ValueObject a, ValueObject b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject a, ValueObject b)
    {
        return !(a == b);
    }
}