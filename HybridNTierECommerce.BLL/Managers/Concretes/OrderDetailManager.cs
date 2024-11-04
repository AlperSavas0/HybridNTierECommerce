using AutoMapper;
using HybridNTierECommerce.DTO.DomainDTOs;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class OrderDetailManager:BaseManager<OrderDetail,OrderDetailDTO>,IOrderDetailManager
    {
        IOrderDetailRepository _odRep;

        public OrderDetailManager(IOrderDetailRepository odRep,IMapper mapper) :base(odRep,mapper) 
        {
            _odRep = odRep;
        }
        public override string Destroy(OrderDetailDTO item)
        {
            return "Cannot destroy OrderDetail directly. It will be removed when Product or Order is deleted.";
        }
        public override string DestroyRange(List<OrderDetailDTO> list)
        {
            return "Cannot destroy OrderDetail directly. It will be removed when Product or Order is deleted.";
        }
    }
}
