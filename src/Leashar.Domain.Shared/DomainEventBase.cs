using MediatR;

namespace Leashar.Domain.Shared;

public abstract class DomainEventBase : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}