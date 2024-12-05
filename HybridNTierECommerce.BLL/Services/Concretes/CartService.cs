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

        public void SetCartForSession(string key, Cart cart)
        {
            cart.CartItems = cart.MyCart.Values.ToList();
            cart.TotalPrice = cart.MyCart.Values.Sum(x => x.SubTotal);
            _sessionService.SetObject(key, cart);
        }

        public CartDTO GetCartFromSession(string key)
        {
            return _mapper.Map<CartDTO>(_sessionService.GetObject<Cart>(key));
        }
       

        public async Task AddToCartAsync(string key,int id)
        {
            CartItem cItem = _mapper.Map<CartItem>(await _productManager.FindAsync(id));
            CartDTO cDto = GetCartFromSession(key) ?? new CartDTO { MyCart = new Dictionary<int, CartItemDTO>() };
            Cart cart = _mapper.Map<Cart>(cDto);

            if (!cart.MyCart.ContainsKey(cItem.ID)) cart.MyCart.Add(cItem.ID, cItem);
            cart.MyCart[cItem.ID].Amount++;

            FinalizeCart(key, cart);
        }

        public void DescreaseFromCart(string key, int id)
        {
            CartDTO cDto = GetCartFromSession(key);
            Cart cart = _mapper.Map<Cart>(cDto);
            cart.MyCart[id].Amount--;
            if (cart.MyCart[id].Amount == 0) cart.MyCart.Remove(id);

            FinalizeCart(key, cart);
        }

        public void RemoveFromCart(string key, int id)
        {
            CartDTO cDto = GetCartFromSession(key);
            Cart cart = _mapper.Map<Cart>(cDto);
            cart.MyCart.Remove(id);

            FinalizeCart(key, cart);
        }

        private void FinalizeCart(string key, Cart cart)
        {
            cart.CartItems = cart.MyCart.Values.ToList();
            cart.TotalPrice = cart.MyCart.Values.Sum(x => x.SubTotal);
            SetCartForSession(key, cart);
        }
    }
}
