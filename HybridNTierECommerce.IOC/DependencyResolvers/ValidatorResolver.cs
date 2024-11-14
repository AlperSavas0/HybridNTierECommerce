using FluentValidation;
using FluentValidation.AspNetCore;
using HybridNTierECommerce.IOC.Validators;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.RequestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.DependencyResolvers
{
    public static class ValidatorResolver
    {
        public static void AddValidatorServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();

            services.AddScoped<IValidator<UserRegisterRequestModel>, UserRegisterRequestModelValidator>();
            services.AddScoped<IValidator<UserSignInRequestModel>, UserSignInRequestModelValidator>();

            services.AddScoped<IValidator<CreateCategoryRequestModel>, CreateCategoryRequestModelValidator>();
            services.AddScoped<IValidator<UpdateCategoryRequestModel>, UpdateCategoryRequestModelValidator>();

            services.AddScoped<IValidator<CreateProductRequestModel>, CreateProductRequestModelValidator>();
            services.AddScoped<IValidator<UpdateProductRequestModel>, UpdateProductRequestModelValidator>();
        }
    }
}
