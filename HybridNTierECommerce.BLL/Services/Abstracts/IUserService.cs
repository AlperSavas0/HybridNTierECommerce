using HybridNTierECommerce.DTO.User;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Services.Abstracts
{
    public interface IUserService
    {
        Task<IdentityResult> UserRegisterAsync(UserRegisterRequestModelDTO userDTO);
        Task<(bool , string)> ConfirmEmailAsync(ConfirmEmailDTO emailDto);
        Task<(SignInResult, IList<string>?)> SignInAsync(UserSignInRequestModelDTO signInDto);
    }
}
