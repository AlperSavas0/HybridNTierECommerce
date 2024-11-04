using FluentValidation;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.Validators
{
    public class UserSignInRequestModelValidator : AbstractValidator<UserSignInRequestModel>
    {
        public UserSignInRequestModelValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Userame cannot be empty.")
                .Length(3, 15).WithMessage("Username must be between 3 and 15 characters");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password cannot be empty")
                .MinimumLength(3).WithMessage("Password must be at least 3 characters long");
        }
    }
}
