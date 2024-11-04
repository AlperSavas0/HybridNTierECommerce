using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DTO.ProductDTOs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PageVMs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HybridNTierECommerce.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {

        readonly IProductManager _productManager;
        readonly ICategoryManager _catManager;
        readonly IMapper _mapper;
        readonly IValidator<CreateProductRequestModel> _createProductRequestValidator;

        public ProductController(IProductManager productManager, ICategoryManager catManager, IMapper mapper, IValidator<CreateProductRequestModel> createProductRequestValidator)
        {
            _productManager = productManager;
            _catManager = catManager;
            _mapper = mapper;
            _createProductRequestValidator = createProductRequestValidator;
        }

        public IActionResult GetProducts()
        {
            List<ProductResponseModel> pRM = _mapper.Map<List<ProductResponseModel>>(_productManager.GetAll());
            return View(pRM);
        }


        public IActionResult CreateProduct()
        {
            CreateProductPageVM cpVM = new()
            {
                Categories = _mapper.Map<List<CategoryResponseModel>>(_catManager.GetActives())
            };
            return View(cpVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductPageVM model, IFormFile formFile)
        {
            model.Categories = _mapper.Map<List<CategoryResponseModel>>(_catManager.GetActives());

            ValidationResult validationResult = _createProductRequestValidator.Validate(model.Product);
            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors) ModelState.AddModelError($"Product.{error.PropertyName}", error.ErrorMessage);
                return View(model);
            }
            string result = await _productManager.CreateProductAsync(_mapper.Map<ProductDTO>(model.Product), formFile);
            TempData["Message"] = result;
            if (result == "Successfully added") return RedirectToAction("GetProducts");

            
            return View(model);
        }
        public async Task<IActionResult> UpdateProduct(int id)
        {
            UpdateProductPageVM uPPVM = new()
            {
                Product = _mapper.Map<UpdateProductRequestModel>(await _productManager.FindAsync(id)),
                Categories = _mapper.Map<List<CategoryResponseModel>>(_catManager.GetActives())
            };
            return View(uPPVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductPageVM model, IFormFile formfile)
        {
            ProductDTO pDto= _mapper.Map<ProductDTO>(model.Product);
            await _productManager.UpdateProductAsync(pDto, formfile);
            return RedirectToAction("GetProducts");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _productManager.Delete(await _productManager.FindAsync(id));
            return RedirectToAction("GetProducts");
        }

        public async Task<IActionResult> DestroyProduct(int id)
        {
            ProductDTO pDTO= await _productManager.FindAsync(id);
            TempData["Message"]=_productManager.Destroy(pDTO);
            return RedirectToAction("GetProducts");
        }
    }
}
