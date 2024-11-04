using HybridNTierECommerce.DTO.DomainDTOs;
using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class OrderDetailProfile : BaseProfile
    {
        public OrderDetailProfile()
        {
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();

            CreateMap<OrderDetailDTO,CartItemDTO>()
                .ForMember(dest=>dest.ID,opt=>opt.MapFrom(src=>src.ProductID))
                .ForMember(dest=>dest.Amount,opt=>opt.MapFrom(src=>src.Quantity))
                .ForMember(dest=>dest.UnitPrice,opt=>opt.MapFrom(src=>src.Price))
                .ReverseMap();
        }
    }
}
