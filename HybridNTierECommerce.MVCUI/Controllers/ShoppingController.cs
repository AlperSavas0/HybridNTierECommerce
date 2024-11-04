using AutoMapper;
using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.DTO.OrderDTOs;
using HybridNTierECommerce.DTO.ShoppingTools;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.OrderVMs.PageVMs;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.ResponseModels;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ShoppingVMs.PageVMs;

using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using X.PagedList;
using X.PagedList.Extensions;

namespace HybridNTierECommerce.MVCUI.Controllers
{
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _catManager;
        readonly IMapper _mapper;
        readonly ICartService _cartService;
        readonly IOrderManager _orderManager;
        public ShoppingController(IProductManager productManager, ICategoryManager catManager, IMapper mapper, ICartService cartService, IOrderManager orderManager)
        {
            _productManager = productManager;
            _catManager = catManager;
            _mapper = mapper;
            _cartService = cartService;
            _orderManager = orderManager;
        }


        public IActionResult Index(int? page, int? categoryID)
        {
            List<ProductResponseModel> products = _mapper.Map<List<ProductResponseModel>>(categoryID == null ? _productManager.GetActives() : _productManager.Where(x => x.CategoryID == categoryID));
            List<CategoryResponseModel> categories = _mapper.Map<List<CategoryResponseModel>>(_catManager.GetActives());

            ShoppingPageVM spVM = new()
            {
                Categories = categories,
                Products = products.ToPagedList(page ?? 1, 8)
            };
            return View(spVM);
        }

        public IActionResult CartPage()
        {
            CartPageVM cPVM = _mapper.Map<CartPageVM>(_cartService.GetCartFromSession("scart"));
            if (cPVM == null || cPVM.CartItems.Count == 0)
            {
                TempData["Message"] = "Your cart is empty";
                return RedirectToAction("Index");
            }
            return View(cPVM);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            await _cartService.AddToCartAsync("scart", id);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseFromCart(int id)
        {
            _cartService.DescreaseFromCart("scart", id);
            return RedirectToAction("CartPage");
        }

        public IActionResult DeleteFromCart(int id)
        {
            _cartService.RemoveFromCart("scart", id);
            return RedirectToAction("CartPage");
        }

        public IActionResult ConfirmOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmOrder(OrderRequestPageVM oRPVM)
        {
            string userId=User.Identity.IsAuthenticated? User.FindFirstValue(ClaimTypes.NameIdentifier) : null;
            OrderRequestPageVMDTO oVmDTO= _mapper.Map<OrderRequestPageVMDTO>(oRPVM);

            bool result = await _orderManager.ConfirmeOrderAsync(oVmDTO, userId);

            if (result)
            {
                TempData["Message"] = "Siparişiniz başarıyla alınmıştır.";
            }
            else TempData["Message"] = "Sipariş işlemi sırasında bir hata oluştu.";

            return RedirectToAction("Index");
        }
    }
}
