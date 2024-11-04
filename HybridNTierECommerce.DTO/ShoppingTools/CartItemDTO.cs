using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.DTO.ShoppingTools
{
    public class CartItemDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get { return Amount * UnitPrice; }}
        public string ImagePath { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryID { get; set; }
    }
}
