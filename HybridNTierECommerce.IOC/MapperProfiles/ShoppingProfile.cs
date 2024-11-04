using AutoMapper;
using HybridNTierECommerce.DTO.CommonDTO;
using HybridNTierECommerce.DTO.ProductDTOs;
using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTıerECommerce.VIEWMODEL.Models.ShoppingTools;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.PaymentAPITools;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ShoppingVMs.PageVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class ShoppingProfile:Profile
    {
        public ShoppingProfile()
        {
            CreateMap<Cart,CartDTO>().ReverseMap();
            CreateMap<CartItemDTO,ProductDTO>().ForMember(dest=>dest.Price ,opt=>opt.MapFrom(src=>src.UnitPrice)).ReverseMap();
            CreateMap<CartItemDTO,CartItem>().ReverseMap();
            CreateMap<CartDTO, CartPageVM>().ReverseMap();

            CreateMap<PaymentRequestModel,PaymentRequestModelDTO>().ReverseMap();
        }
    }
}
