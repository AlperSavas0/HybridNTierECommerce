using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs
{
    public class CreateProductPageVM
    {
        public List<CategoryResponseModel> Categories{ get; set; }
        public CreateProductRequestModel Product{ get; set; }
    }
}
