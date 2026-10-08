using AutoPlex.Repository.Context;
using AutoPlex.Repository.Interface;
using AutoPlex.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPlex.Repository
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryContext, RepositoryContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
