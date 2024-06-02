using Ardalis.Specification;

namespace Leashar.Domain.Shared.Repositories;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
    
}
