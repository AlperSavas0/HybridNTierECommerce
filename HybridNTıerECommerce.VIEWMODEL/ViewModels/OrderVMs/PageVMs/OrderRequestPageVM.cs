using HybridNTıerECommerce.VIEWMODEL.ViewModels.OrderVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.PaymentAPITools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.OrderVMs.PageVMs
{
    public class OrderRequestPageVM
    {
        public OrderResponseModel Order { get; set; }
        public PaymentRequestModel Payment { get; set; }
    }
}
