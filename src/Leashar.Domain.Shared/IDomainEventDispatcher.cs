using Leashar.Domain.Shared.Entities;

namespace Leashar.Domain.Shared;

public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents<TId>(IEnumerable<EntityBase<TId>> entitiesWithEvents) where TId : IEquatable<TId>;
}