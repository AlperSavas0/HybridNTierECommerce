using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DTO.CategoryDTOs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.RequestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HybridNTierECommerce.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        readonly ICategoryManager _catManager;
        readonly IMapper _mapper;
        readonly IValidator<CreateCategoryRequestModel> _createCategoryRequestValidator;
        readonly IValidator<UpdateCategoryRequestModel> _updateCategoryRequestValidator;

        public CategoryController(ICategoryManager catManager, IMapper mapper, IValidator<CreateCategoryRequestModel> createCategoryRequestValidator, IValidator<UpdateCategoryRequestModel> updateCategoryRequestValidator)
        {
            _catManager = catManager;
            _mapper = mapper;
            _createCategoryRequestValidator = createCategoryRequestValidator;
            _updateCategoryRequestValidator = updateCategoryRequestValidator;
        }

        public IActionResult GetCategories()
        {
            List<CategoryResponseModel> cResVMs = _mapper.Map<List<CategoryResponseModel>>(_catManager.GetAll());
            return View(cResVMs);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestModel model)
        {
            ValidationResult validationResult = _createCategoryRequestValidator.Validate(model);
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure? item in validationResult.Errors) ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                return View(model);
            }
            TempData["Message"] = await _catManager.AddAsync(_mapper.Map<CategoryDTO>(model));
            return RedirectToAction("GetCategories");
        }
        public async Task<IActionResult> UpdateCategory(int id)
        {
            UpdateCategoryRequestModel uCRM = _mapper.Map<UpdateCategoryRequestModel>(await _catManager.FindAsync(id));
            return View(uCRM);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequestModel model)
        {
            ValidationResult validationResult = _updateCategoryRequestValidator.Validate(model);
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure item in validationResult.Errors) ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                return View(model);
            }

            //if (!ModelState.IsValid) return View(model);
            TempData["Message"] = await _catManager.UpdateAsync(_mapper.Map<CategoryDTO>(model));
            return RedirectToAction("GetCategories");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            _catManager.Delete(await _catManager.FindAsync(id));
            return RedirectToAction("GetCategories");
        }

        public IActionResult DestroyCategory(int id)
        {
            CategoryDTO cDto = _catManager.Find(id);
            TempData["Message"] = _catManager.Destroy(cDto);
            return RedirectToAction("GetCategories");
        }

    }
}
