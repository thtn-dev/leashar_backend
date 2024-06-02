namespace Leashar.Domain.Shared.Entities;

public abstract class EntityBase<T> : IEntityBase<T>
    where T : IEquatable<T>
{
    public T Id { get; set; }
}

public abstract class EntityAuditableBase<T> : EntityBase<T>, IAuditableEntity
    where T : IEquatable<T>
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}