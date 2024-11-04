using HybridNTierECommerce.DTO.OrderDTOs;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Abstracts
{
    public interface IOrderManager : IManager<Order, OrderDTO>
    {
        Task<bool> ConfirmeOrderAsync(OrderRequestPageVMDTO oVmDto, string userID);
    }
}
