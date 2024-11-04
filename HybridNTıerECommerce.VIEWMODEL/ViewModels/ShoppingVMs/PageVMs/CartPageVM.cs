using HybridNTıerECommerce.VIEWMODEL.Models.ShoppingTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ShoppingVMs.PageVMs
{
    public class CartPageVM
    {//Created as PageVM to consider future development
        public List<CartItem> CartItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
