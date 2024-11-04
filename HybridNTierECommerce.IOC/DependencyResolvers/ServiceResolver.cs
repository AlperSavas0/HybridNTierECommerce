using FluentValidation.AspNetCore;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.BLL.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.DependencyResolvers
{
    public static class ServiceResolver
    {
        public static void AddBusinessLogicServices(this IServiceCollection services)
        {            
            services.AddHttpContextAccessor();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISessionService,SessionService>();

            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IApiService, ApiService>();
        }
    }
}
