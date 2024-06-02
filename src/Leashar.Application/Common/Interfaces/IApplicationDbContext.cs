using Leashar.Domain.Courses;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<CourseEntity> Courses { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}


