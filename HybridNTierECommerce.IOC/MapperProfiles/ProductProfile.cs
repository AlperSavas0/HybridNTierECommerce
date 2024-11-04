using HybridNTierECommerce.DTO.ProductDTOs;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class ProductProfile : BaseProfile
    {
        public ProductProfile()
        {

            CreateMap<Product, ProductDTO>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
            CreateMap<ProductDTO, Product>().ForMember(dest => dest.Status, opt => opt.Condition(src => !string.IsNullOrEmpty(src.Status)));
                //.ForMember(dest => dest.Category, opt => opt.Ignore());
          
            CreateMap<ProductDTO, CreateProductRequestModel>().ReverseMap();
            CreateMap<ProductDTO, ProductResponseModel>().ReverseMap();

            CreateMap<ProductDTO, UpdateProductRequestModel>().ReverseMap();
        }
    }
}
