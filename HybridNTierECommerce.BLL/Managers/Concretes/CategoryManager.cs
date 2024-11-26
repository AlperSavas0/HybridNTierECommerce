using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HybridNTierECommerce.DTO.CategoryDTOs;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{
    public class CategoryManager : BaseManager<Category, CategoryDTO>, ICategoryManager
    {
        readonly ICategoryRepository _catRep;

        public CategoryManager(ICategoryRepository catRep, IMapper mapper) : base(catRep, mapper)
        {
            _catRep = catRep;
        }
        public override string Add(CategoryDTO item)
        {
            if (_catRep.Any(x => x.CategoryName == item.CategoryName)) return "This category already exist";
            return base.Add(item);
        }
        public override async Task<string> AddAsync(CategoryDTO item)
        {
            if (await _catRep.AnyAsync(x => x.CategoryName == item.CategoryName)) return "This category already exist";
            return await base.AddAsync(item);
        }
        public override async Task<string> UpdateAsync(CategoryDTO item)
        {
            if (await _catRep.AnyAsync(x => x.CategoryName == item.CategoryName)) return "This category already exist";
            return await base.UpdateAsync(item);
        }
    }
}
