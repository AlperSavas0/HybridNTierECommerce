using AutoMapper;
using HybridNTierECommerce.IOC.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.DependencyResolvers
{
    public static class MapperResolver
    {
        public static void AddMapperServices(this IServiceCollection services)
        {
            MapperConfiguration mapConfiguration = new MapperConfiguration(x =>
            {
                x.AddProfile(new CategoryProfile());
                x.AddProfile(new AppUserProfile());
                x.AddProfile(new AppUserProfileProfile());
                x.AddProfile(new OrderDetailProfile());
                x.AddProfile(new OrderProfile());
                x.AddProfile(new ProductProfile());
                x.AddProfile(new ShoppingProfile());
            });

            IMapper mapper = mapConfiguration.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
