using System.Reflection;
using FluentValidation;
using Leashar.Application.Common.Behaviours;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Leashar.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));

            });
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehaviour<,>));
            return services;
        }
    }

}
