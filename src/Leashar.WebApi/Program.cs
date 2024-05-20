
using Leashar.WebApi.Extensions;

namespace Leashar.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args)
                .AddServices();

            var app = builder.Build()
                .ConfigurePipelines();

            app.Run();
        }
    }
}
