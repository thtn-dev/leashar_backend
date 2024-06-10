using Leashar.Application.Common.Repositories;
using Leashar.Domain.Common.Options;
using Leashar.Domain.Shared;
using Leashar.Infrastructure.Common.Repositories;
using Leashar.Infrastructure.Data.Contexts;
using Leashar.Infrastructure.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Leashar.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFramework(configuration);
            services.AddRepositories();
            return services;
        }
        
        private static void AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            var dbOptions = configuration.GetSection(nameof(DatabaseOptions)).Get<DatabaseOptions>();
            ArgumentNullException.ThrowIfNull(dbOptions, nameof(DatabaseOptions));
            services.AddSingleton(dbOptions);
            services.AddDbContextPool<AppDbContext>(options =>
            {
                var connBuilder = new NpgsqlConnectionStringBuilder
                {
                    Host = dbOptions.Host,
                    Username = dbOptions.User,
                    Password = dbOptions.Password,
                    Database = dbOptions.Database,
                    SslMode = dbOptions.SslMode == "require" ? SslMode.Require : SslMode.Disable,
                    Port = dbOptions.Port
                };
                var connectionString = connBuilder.ToString();
                options.UseNpgsql(connectionString, builder =>
                {
                    builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                });
            });
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
        }
    }
}
