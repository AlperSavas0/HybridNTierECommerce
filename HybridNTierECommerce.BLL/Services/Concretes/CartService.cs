using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTıerECommerce.VIEWMODEL.Models.ShoppingTools;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Concretes
{
    public class CartService : ICartService
    {
        private readonly ISessionService _sessionService;
        readonly IMapper _mapper;
        readonly IProductManager _productManager;
        public CartService(ISessionService sessionService, IMapper mapper, IProductManager productManager)
        {
            _sessionService = sessionService;
            _mapper = mapper;
            _productManager = productManager;
        }

        public void SetCartForSession(string key, CartDTO cDto)
        {
            cDto.CartItems = cDto.MyCart.Values.ToList();
            cDto.TotalPrice = cDto.MyCart.Values.Sum(x => x.SubTotal);
            _sessionService.SetObject(key, _mapper.Map<Cart>(cDto));
        }

        public CartDTO GetCartFromSession(string key)
        {
            return _mapper.Map<CartDTO>(_sessionService.GetObject<Cart>(key));
        }
       

        public async Task AddToCartAsync(string key,int id)
        {
            CartItemDTO cItemDto = _mapper.Map<CartItemDTO>(await _productManager.FindAsync(id));
            CartDTO cDto = GetCartFromSession(key) ?? new CartDTO { MyCart = new Dictionary<int, CartItemDTO>() };

            if (!cDto.MyCart.ContainsKey(cItemDto.ID)) cDto.MyCart.Add(cItemDto.ID, cItemDto);
            cDto.MyCart[cItemDto.ID].Amount++;

            FinalizeCart(key, cDto);
        }

        public void DescreaseFromCart(string key, int id)
        {
            CartDTO cDto = GetCartFromSession(key);
            cDto.MyCart[id].Amount--;
            if (cDto.MyCart[id].Amount == 0) cDto.MyCart.Remove(id);

            FinalizeCart(key, cDto);
        }

        public void RemoveFromCart(string key, int id)
        {
            CartDTO cDto = GetCartFromSession(key);
            cDto.MyCart.Remove(id);
        }

        private void FinalizeCart(string key, CartDTO cDto)
        {
            cDto.CartItems = cDto.MyCart.Values.ToList();
            cDto.TotalPrice = cDto.MyCart.Values.Sum(x => x.SubTotal);
            SetCartForSession(key, cDto);
        }
    }
}
