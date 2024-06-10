using Leashar.Domain.Shared;
using Leashar.Domain.Shared.Entities;
using Leashar.Domain.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Leashar.Infrastructure.Common.Repositories
{
    public interface IEfRepository<T, TK, TContext> : IQueryRepositoryBase<T, TK>
        where T : class, IEntityBase<TK>, IAggregateRoot
        where TK : IEquatable<TK>
        where TContext : DbContext
    {
    }

    public abstract class EfRepositoryBase<T, TK, TContext> : IEfRepository<T, TK, TContext>
        where T : class, IEntityBase<TK>, IAggregateRoot
        where TK : IEquatable<TK>
        where TContext : DbContext
    {
        protected readonly TContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public EfRepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return _dbSet.AnyAsync(cancellationToken);
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return _dbSet.AnyAsync(predicate, cancellationToken);
        }

        public Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return _dbSet.CountAsync(cancellationToken);
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return _dbSet.CountAsync(predicate, cancellationToken);
        }

        public Task<T?> FirstOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            return _dbSet.FirstOrDefaultAsync(cancellationToken);
        }

        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return _dbSet.FirstOrDefaultAsync(predicate, cancellationToken);
        }


        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return _dbSet.Where(predicate).ToListAsync(cancellationToken);
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default, params Expression<Func<T, object[]>>[] includes)
        {
            return includes.Aggregate(_dbSet.Where(predicate), (current, include) => current.Include(include)).ToListAsync(cancellationToken);
        }

        public Task<T?> GetByIdAsync(TK id, CancellationToken cancellationToken = default)
        {
            Expression<Func<T, bool>> func = x => x.Id.Equals(id);
            return _dbSet.FirstOrDefaultAsync(func, cancellationToken);
        }
    }   
}
