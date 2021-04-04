using Microsoft.Extensions.DependencyInjection;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renter.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAplicationRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
