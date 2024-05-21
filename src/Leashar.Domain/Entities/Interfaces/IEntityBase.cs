namespace Leashar.Domain.Entities.Interfaces;

public interface IEntityBase<T>
{
    T Id { get; set; }
}

public interface IDateTracking
{
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset? ModifiedDate { get; set; }
}

public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
}

public interface IAuditableEntity : IDateTracking, ISoftDelete
{
    public string CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
}
