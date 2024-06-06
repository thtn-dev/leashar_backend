using Ardalis.Specification;
using Leashar.Application.Common.Interfaces;
using Leashar.Domain.Shared;
using Leashar.Domain.Shared.Entities;
using Leashar.Domain.Shared.Repositories;
using Leashar.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Infrastructure.Common
{
    public interface IRepository3<T, TK, TContext> : IRepository2<T, TK> where T : EntityBase<TK>, IAggregateRoot where TK : IEquatable<TK>
        where TContext : DbContext, IApplicationDbContext
    {
    }

    public abstract class RepositoryBase<T, TK, TContext> : IRepository3<T, TK, TContext>
        where T : EntityBase<TK>, IAggregateRoot where TK : IEquatable<TK>
        where TContext : DbContext, IApplicationDbContext
    {

        protected readonly TContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dbSet.Add(entity);
            return Task.FromResult(entity);
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            _dbSet.AddRange(entities);
            return Task.FromResult(entities);
        }

        public Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<T> AsAsyncEnumerable(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> FirstOrDefaultAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult?> FirstOrDefaultAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetBySpecAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();

        }

        public Task<TResult?> GetBySpecAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ListAsync(ISpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> ListAsync<TResult>(ISpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T?> SingleOrDefaultAsync(ISingleResultSpecification<T> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult?> SingleOrDefaultAsync<TResult>(ISingleResultSpecification<T, TResult> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

    public class UserRepository : RepositoryBase<UserEntity, string>
    {
    }
}
