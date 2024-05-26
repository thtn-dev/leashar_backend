using Leashar.Domain.Entities.Interfaces;

namespace Leashar.Domain.Entities.Abstracts;

public abstract class EntityAuditableBase<T> : EntityBase<T>, IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}

public abstract class EntityDateTrackingBase<T> : EntityBase<T>, IDateTracking
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}

public abstract class EntitySoftDeleteBase<T> : EntityBase<T>, ISoftDelete
{
    public bool IsDeleted { get; set; }
}