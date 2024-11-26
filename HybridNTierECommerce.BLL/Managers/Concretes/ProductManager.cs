using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Enums;
using HybridNTierECommerce.ENTITIES.Interfaces;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.ProductDTOs;
using Microsoft.AspNetCore.Http;
using HybridNTierECommerce.DTO.DomainDTOs;
//using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class ProductManager : BaseManager<Product, ProductDTO>, IProductManager
    {
        IProductRepository _pRep;
        IOrderDetailManager _orderDetailManager;

        public ProductManager(IProductRepository pRep, IMapper mapper, IOrderDetailManager orderDetailManager) : base(pRep, mapper)
        {
            _pRep = pRep;
            _orderDetailManager = orderDetailManager;
        }

        private static async Task<string?> AddPicture(ProductDTO pDto, IFormFile formFile)
        {
            if (formFile != null && formFile.Length > 0)
            {
                Guid uniqueName = Guid.NewGuid();
                string extension = Path.GetExtension(formFile.FileName);
                pDto.ImagePath = $"/images/{uniqueName}{extension}";

                string path = $"{Directory.GetCurrentDirectory()}/wwwroot{pDto.ImagePath}";

                using (FileStream stream = new(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                return null;
            }
            else
            {
                if (string.IsNullOrEmpty(pDto.ImagePath)) return "Please load a picture";

                return null;
            }
        }
        public async Task<string> CreateProductAsync(ProductDTO pDto, IFormFile formFile)
        {
            string message = await AddPicture(pDto, formFile);
            if (message != null) return message;

            return await AddAsync(pDto);
        }

        public async Task UpdateProductAsync(ProductDTO pDto, IFormFile formFile)
        {
            await AddPicture(pDto, formFile);
            await UpdateAsync(pDto);
        }
        public override string Destroy(ProductDTO item)
        {
            foreach (OrderDetailDTO od in _orderDetailManager.Where(x => x.ProductID == item.ID))
            {
                if (od.Status != "Deleted") return "All related OrderDetails must be deleted first.";
            }

            return base.Destroy(item);
        }
    }
}
