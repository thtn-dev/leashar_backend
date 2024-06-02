using Leashar.Domain.Shared;

namespace Leashar.Domain.Users.Events;

public sealed class UserCreatedEvent : DomainEventBase
{
    public string UserId { get; init; }
    public UserCreatedEvent(string userId)
    {   
        UserId = userId;
    }
}