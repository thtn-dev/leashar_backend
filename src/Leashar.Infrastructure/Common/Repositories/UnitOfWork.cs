using Leashar.Application.Common.Repositories;
using Leashar.Domain.Shared;
using Microsoft.EntityFrameworkCore;
namespace Leashar.Infrastructure.Common.Repositories;



public class UnitOfWork<TContext> : IUnitOfWork
    where TContext : DbContext
{
    private bool _disposed;
    private readonly TContext _dbContext;

    public IUserRepository UserRepo { get; }

    public UnitOfWork(TContext context, IUserRepository userRepository)
    {
        _dbContext = context;
        _disposed = false;
        UserRepo = userRepository;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

   
    private void CheckDisposed()
    {
        if (!_disposed)
            return;
        throw new ObjectDisposedException(GetType().Name);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
            if (disposing)
                _dbContext.Dispose();
        _disposed = true;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellation = default)
    {
        CheckDisposed();
        return _dbContext.SaveChangesAsync(cancellation);
    }
}