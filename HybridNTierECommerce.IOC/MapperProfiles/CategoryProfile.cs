using HybridNTierECommerce.DTO.CategoryDTOs;
using HybridNTierECommerce.ENTITIES.Enums;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.RequestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class CategoryProfile : BaseProfile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap().ForMember(dest => dest.Status, opt => opt.Condition(src => !string.IsNullOrEmpty(src.Status))); ;

           
            CreateMap<CategoryDTO, CategoryResponseModel>().ReverseMap();
            CreateMap<CategoryDTO, CreateCategoryRequestModel>().ReverseMap();
            CreateMap<CategoryDTO, UpdateCategoryRequestModel>().ReverseMap();

            CreateMap<CategoryResponseModel, CategoryResponseModelDTO>().ReverseMap();//gerek kalmayabilir

        }
    }
}
