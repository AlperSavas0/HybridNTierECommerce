using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs
{
    public class UpdateProductPageVM
    {
        public List<CategoryResponseModel> Categories { get; set; }
        public UpdateProductRequestModel Product { get; set; }
    }
}
