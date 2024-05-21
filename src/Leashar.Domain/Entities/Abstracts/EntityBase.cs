using Leashar.Domain.Entities.Interfaces;
#nullable disable
namespace Leashar.Domain.Entities.Abstracts;

public abstract class EntityBase<T> : IEntityBase<T>
{
    public T Id { get; set; }
}
