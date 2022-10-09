using APIApp.DAL.Repositories;
using APIApp.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApp.AppConfiq
{
    public static class DependencyInjecttion
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IItemRepository, ItemRepository>();
            return services;
        }
    }
}
