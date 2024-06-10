

using Leashar.Application.Common.Repositories;
using Leashar.Domain.Users;
using Leashar.Infrastructure.Common.Repositories;
using Leashar.Infrastructure.Data.Contexts;

namespace Leashar.Infrastructure.Users
{
    public class UserRepository : EfRepositoryBase<UserEntity, string, AppDbContext>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void AddAsync(UserEntity userEntity)
        {
            _dbContext.Users.Add(userEntity);
        }
    }
}
