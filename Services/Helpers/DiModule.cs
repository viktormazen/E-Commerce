using DataAccess;
using DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OrderDbContext>(x => x.UseSqlServer(connectionString));

            //services.AddTransient<>

            services.AddTransient<IRepository<OrderDto>, OrderRepository>();

            return services;
        }
    }
}
