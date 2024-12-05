using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTıerECommerce.VIEWMODEL.Models.ShoppingTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Abstracts
{
    public interface ICartService
    {
        void SetCartForSession(string key, Cart cart);
        CartDTO GetCartFromSession(string key);
        Task AddToCartAsync(string key, int id);
        void DescreaseFromCart(string ket, int id);
        void RemoveFromCart(string key, int id);
    }
}
