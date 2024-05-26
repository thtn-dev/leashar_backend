using Leashar.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Leashar.Infrastructure.Data.Interceptors;

public class AuditableEntityInterceptor : SaveChangesInterceptor
{
    private readonly IUserEntity _userEntity;
    private readonly TimeProvider _timeProvider;

    public AuditableEntityInterceptor(IUserEntity userEntity, TimeProvider timeProvider)
    {
        _userEntity = userEntity;
        _timeProvider = timeProvider;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        return base.SavingChanges(eventData, result);
    }
    
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
    
    private void SetAuditableEntityProperties(EntityEntry entry)
    {
        if (entry.Entity is IAuditableEntity entity)
        {
            var now = _timeProvider.GetUtcNow();
            var user = _userEntity;
            switch (entry.State)
            {
                case EntityState.Added:
                    entity.CreatedAt = now;
                    entity.CreatedBy = user.Id;
                    break;
                case EntityState.Modified:
                    entity.UpdatedAt = now;
                    entity.UpdatedBy = user.Id;
                    break;
            }
        }
    }
}