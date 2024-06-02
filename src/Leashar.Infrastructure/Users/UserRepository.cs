using Ardalis.Specification;
using Leashar.Application.Common.Repositories;
using Leashar.Domain.Users;

namespace Leashar.Infrastructure.Users;

public class UserRepository : IUserRepository
{
    public Task<UserEntity?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = new CancellationToken()) where TId : notnull
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> GetBySpecAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<UserEntity, TResult> specification,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> FirstOrDefaultAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<UserEntity, TResult> specification,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> SingleOrDefaultAsync(ISingleResultSpecification<UserEntity> specification,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<UserEntity, TResult> specification,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<List<UserEntity>> ListAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<List<UserEntity>> ListAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<List<TResult>> ListAsync<TResult>(ISpecification<UserEntity, TResult> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<UserEntity> AsAsyncEnumerable(ISpecification<UserEntity> specification)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity> AddAsync(UserEntity entity, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserEntity>> AddRangeAsync(IEnumerable<UserEntity> entities, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserEntity entity, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeAsync(IEnumerable<UserEntity> entities, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(UserEntity entity, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(IEnumerable<UserEntity> entities, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(ISpecification<UserEntity> specification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}