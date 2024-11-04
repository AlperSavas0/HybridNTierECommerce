using AutoMapper;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.DTO.User;
using HybridNTierECommerce.ENTITIES.Models;
using HybridNTierECommerce.MVCUI.Models;
using HybridNTýerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace HybridNTierECommerce.MVCUI.Controllers
{
    //http://localhost:5036/
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IMapper _mapper;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IMapper mapper, IUserService userService)
        {
            _logger = logger;
            _mapper = mapper;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            UserRegisterRequestModelDTO userDTO = _mapper.Map<UserRegisterRequestModelDTO>(model);

            IdentityResult result = await _userService.UserRegisterAsync(userDTO);
            if (result.Succeeded)
            {
                TempData["Message"] = "Please check your email to confirm your account.";
                return RedirectToAction("RedirectPanel");
            }
            return View();
        }

        public IActionResult RedirectPanel()
        {
            return View();
        }

        public async Task<IActionResult> ConfirmEmail(Guid specId, int id)
        {
            ConfirmEmailDTO dto = new() { SpecId = specId, UserId = id };
            (bool isSuccess,string message)= await _userService.ConfirmEmailAsync(dto);

            TempData["Message"] = message;
            if (isSuccess) return RedirectToAction("SignIn");

            return RedirectToAction(message == "User mot found" ? "RedirectPanel" : "Register");
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInRequestModel model)
        {
            if (!ModelState.IsValid) return View(model);

            UserSignInRequestModelDTO signInDto = _mapper.Map<UserSignInRequestModelDTO>(model);

            (SignInResult result, IList<string>? roles) = await _userService.SignInAsync(signInDto);
            if (result.Succeeded)
            {
                if (roles.Contains("Admin")) return RedirectToAction("GetCategories", "Category", new { Area = "Admin" });
                else if (roles.Contains("Member")) return RedirectToAction("Privacy");
                return RedirectToAction("Index");
            }
            else if (result.IsNotAllowed) return RedirectToAction("MailPanel");

            TempData["Message"] = "Invalid username or Password";
            return RedirectToAction("SignIn");
        }

        public IActionResult MailPanel()
        {
            return View();
        }
    }
}
