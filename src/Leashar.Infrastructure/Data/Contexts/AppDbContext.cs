using Leashar.Application.Common.Interfaces;
using Leashar.Domain.Courses;
using Leashar.Domain.Users;
using Leashar.Infrastructure.Data.ModelBuilders;
using Microsoft.EntityFrameworkCore;

namespace Leashar.Infrastructure.Data.Contexts
{
    public class AppDbContext : DbContext, IApplicationDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurations();
        }
        // public DbSet<CourseEntity> Courses { get; set; }
    }
}
