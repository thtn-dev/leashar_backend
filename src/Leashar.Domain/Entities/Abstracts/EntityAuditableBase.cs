using Leashar.Domain.Entities.Interfaces;

namespace Leashar.Domain.Entities.Abstracts;

public abstract class EntityAuditableBase<T> : EntityBase<T>, IAuditableEntity
{
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? ModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
    public string CreatedBy { get; set; } = null!;
    public string? ModifiedBy { get; set; }
}

public abstract class EntityDateTrackingBase<T> : EntityBase<T>, IDateTracking
{
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? ModifiedDate { get; set; }
}

public abstract class EntitySoftDeleteBase<T> : EntityBase<T>, ISoftDelete
{
    public bool IsDeleted { get; set; }
}