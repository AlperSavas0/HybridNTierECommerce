using AutoMapper;
using HybridNTierECommerce.BLL.Services.Abstracts;
using HybridNTierECommerce.COMMON.Tools;
using HybridNTierECommerce.DTO.User;
using HybridNTierECommerce.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace HybridNTierECommerce.BLL.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> UserRegisterAsync(UserRegisterRequestModelDTO userDTO)
        {
            AppUser appUser = _mapper.Map<AppUser>(userDTO);
            appUser.ActivationCode = Guid.NewGuid();

            IdentityResult result = await _userManager.CreateAsync(appUser, userDTO.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, "Member");
                string message = $"Your account has been created. Please click the link: http://localhost:5036/Home/ConfirmEmail?specId={appUser.ActivationCode}&id={appUser.Id}";
                MailService.Send(userDTO.Email, body: message);
            }
            return result;
        }

        public async Task<(bool, string)> ConfirmEmailAsync(ConfirmEmailDTO emailDto)
        {
            AppUser? user = await _userManager.FindByIdAsync(emailDto.UserId.ToString());
            if (user == null) return (false, "User not found");
            if (user.ActivationCode != emailDto.SpecId) return (false, "Invalid confirmation code");

            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            return (true, "Your account has been successfully confirmed");
        }

        public async Task<(SignInResult, IList<string>?)> SignInAsync(UserSignInRequestModelDTO signInDto)
        {
            AppUser? user = await _userManager.FindByNameAsync(signInDto.UserName);
            if (user == null) return (SignInResult.Failed, null);

            SignInResult result = await _signInManager.PasswordSignInAsync(user, signInDto.Password, true, true);
            if (result.Succeeded)
            {
                IList<string> roles = await _userManager.GetRolesAsync(user);
                return (result, roles);
            }
            return (result, null);
        }
    }
}
