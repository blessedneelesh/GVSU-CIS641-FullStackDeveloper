using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoPlex.Services.Abstractions.ServiceInterfaces;
using AutoPlex.Services.Service;

namespace AutoPlex.Services
{
    public static class ServicesServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}
