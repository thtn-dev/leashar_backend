using Leashar.Domain.Courses;
using Leashar.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<CourseEntity> Courses { get; set; }
    DbSet<UserEntity> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}


