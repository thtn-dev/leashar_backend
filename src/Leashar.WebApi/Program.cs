
using Leashar.Infrastructure.Data.Contexts;
using Leashar.WebApi.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Leashar.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args)
                .AddServices();

            var app = builder.Build()
                .ConfigurePipelines()
                .CheckDatabaseConnection();

            app.Run();
        }
        
    }
    
    public static class CheckConnection
    {
        public static IHost CheckDatabaseConnection(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            // get logger
            
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<AppDbContext>>();
            
            
            try
            {
                //context.Database.SetCommandTimeout(30);
                //context.Database.OpenConnection();
                //logger.LogInformation("Database connection established.");
                //context.Database.CloseConnection();
            }
            catch (Exception)
            {
                throw;
            }
            return host;
        }
    }
}
