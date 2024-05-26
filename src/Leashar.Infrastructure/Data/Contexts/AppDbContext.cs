using Leashar.Application.Common.Interfaces;
using Leashar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Infrastructure.Data.Contexts
{
    public class AppDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<CourseEntity> Courses { get; set; }
    }
}
