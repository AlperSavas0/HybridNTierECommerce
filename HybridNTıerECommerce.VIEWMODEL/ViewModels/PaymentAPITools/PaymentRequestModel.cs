using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.PaymentAPITools
{
    public class PaymentRequestModel
    {
        public string CardNumber { get; set; }
        public string CardUserName { get; set; }
        public string CVC { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public decimal ShoppingPrice { get; set; }
    }
}
