using Ardalis.Specification;
using Leashar.Domain.Shared.Entities;

namespace Leashar.Domain.Shared.Repositories;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
    
}


public interface IRepository2<T, TK> : IRepositoryBase<T> where T : EntityBase<TK>, IAggregateRoot where TK : IEquatable<TK>
{

}

