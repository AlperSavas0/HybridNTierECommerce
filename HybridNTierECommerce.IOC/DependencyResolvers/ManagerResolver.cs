using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.BLL.Managers.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppUserProfileManager, AppUserProfileManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IProductManager, ProductManager>();
        }
    }
}
