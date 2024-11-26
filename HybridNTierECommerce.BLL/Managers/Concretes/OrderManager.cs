using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.DTO.DomainDTOs;
using HybridNTierECommerce.DTO.OrderDTOs;
using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class OrderManager : BaseManager<Order, OrderDTO>, IOrderManager
    {
        IOrderRepository _oRep;
        ICartService _cartService;
        IApiService _apiService;
        UserManager<AppUser> _userManager;
        IOrderDetailManager _orderDetailManager;
        public OrderManager(IOrderRepository oRep, IMapper mapper, ICartService cartService, IApiService apiService, UserManager<AppUser> userManager, IOrderDetailManager orderDetailManager) : base(oRep, mapper)
        {
            _oRep = oRep;
            _cartService = cartService;
            _apiService = apiService;
            _userManager = userManager;
            _orderDetailManager = orderDetailManager;
        }

        public async Task<bool> ConfirmeOrderAsync(OrderRequestPageVMDTO oVmDto, string userID)
        {
            CartDTO cDto = _cartService.GetCartFromSession("scart");
            oVmDto.Order.Price = oVmDto.Payment.ShoppingPrice = cDto.TotalPrice;

            (bool isSuccess, string responseBody) = await _apiService.MakePostRequestAsync("http://localhost:5221/api/Transaction", oVmDto.Payment);

            if (isSuccess)
            {
                if (!string.IsNullOrEmpty(userID))
                {
                    AppUser appUser = await _userManager.FindByIdAsync(userID);
                    oVmDto.Order.AppUserID = appUser.Id;
                }

                OrderDTO addedOrder = await AddAndGetAsync(_mapper.Map<OrderDTO>(oVmDto.Order));

                foreach (CartItemDTO item in cDto.CartItems)
                {
                    OrderDetailDTO odDto = _mapper.Map<OrderDetailDTO>(item);
                    odDto.OrderID = addedOrder.ID;
                    await _orderDetailManager.AddAsync(odDto);
                }
                return true;
            }
            return false;
        }

        public override string Destroy(OrderDTO item)
        {
            foreach (OrderDetailDTO od in _orderDetailManager.Where(x => x.ProductID == item.ID))
            {
                if (od.Status != "Deleted") return "All related OrderDetails must be deleted first.";
            }
            return base.Destroy(item);
        }
    }
}
