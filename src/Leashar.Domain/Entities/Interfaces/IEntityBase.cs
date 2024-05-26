namespace Leashar.Domain.Entities.Interfaces;

public interface IEntityBase<T>
{
    T Id { get; set; }
}

public interface IDateTracking
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}

public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
}

public interface IAuditableEntity : IDateTracking, ISoftDelete
{
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}
