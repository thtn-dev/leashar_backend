using Leashar.Application;
using Leashar.Infrastructure;

namespace Leashar.WebApi.Extensions
{
    public static class ServiceConfiguration
    {
        public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApplicationLayer()
                .AddInfrastructureLayer(builder.Configuration);
            return builder;
        }
    }
}
