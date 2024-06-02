using Leashar.Application.Common.Interfaces;
using Leashar.Domain.Courses;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Infrastructure.Data.Contexts
{
    public class AppDbContext : DbContext //, IApplicationDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        // public DbSet<CourseEntity> Courses { get; set; }
    }
}
