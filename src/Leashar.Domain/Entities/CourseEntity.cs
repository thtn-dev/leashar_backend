using Leashar.Domain.Entities.Abstracts;

namespace Leashar.Domain.Entities;

public class CourseEntity : EntityAuditableBase<string>
{
    public string? Description { get; set; }
}