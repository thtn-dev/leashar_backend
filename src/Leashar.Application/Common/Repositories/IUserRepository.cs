

using Leashar.Domain.Shared.Repositories;
using Leashar.Domain.Users;

namespace Leashar.Application.Common.Repositories;
public interface IUserRepository : IQueryRepositoryBase<UserEntity, string>
{
    void AddAsync(UserEntity userEntity);
}