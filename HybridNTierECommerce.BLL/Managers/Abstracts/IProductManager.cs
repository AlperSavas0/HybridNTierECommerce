using HybridNTierECommerce.DTO.ProductDTOs;
using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Abstracts
{
    public interface IProductManager : IManager<Product, ProductDTO>
    {
        Task UpdateProductAsync(ProductDTO pDto, IFormFile formFile);
        Task<string> CreateProductAsync(ProductDTO pDto, IFormFile formFile);
    }
}
