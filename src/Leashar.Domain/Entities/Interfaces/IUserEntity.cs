namespace Leashar.Domain.Entities.Interfaces;

public interface IUserEntity : IEntityBase<string>, IAuditableEntity
{
     string? UserName { get; set; }
     string? Email { get; set; }    
     bool EmailConfirmed { get; set; }
     DateTimeOffset? LockoutEnd { get; set; }
     bool LockoutEnabled { get; set; }
     int AccessFailedCount { get; set; }
}