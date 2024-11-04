using HybridNTierECommerce.DTO.OrderDTOs;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.OrderVMs.PageVMs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.OrderVMs.PureVMs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.MapperProfiles
{
    public class OrderProfile : BaseProfile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO>().ReverseMap();
            
            CreateMap<OrderRequestPageVM,OrderRequestPageVMDTO>().ReverseMap();
            CreateMap<OrderResponseModel,OrderResponseModelDTO>().ReverseMap();
            CreateMap<OrderResponseModelDTO,OrderDTO>().ReverseMap();
        }
    }
}
