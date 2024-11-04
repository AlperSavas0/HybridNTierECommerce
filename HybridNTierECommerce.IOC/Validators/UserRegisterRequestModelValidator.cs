using FluentValidation;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.AppUserVMs.PureVMs.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.Validators
{
    public class UserRegisterRequestModelValidator :AbstractValidator<UserRegisterRequestModel>
    {
        public UserRegisterRequestModelValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Username is required")
                .Length(3, 15).WithMessage("Username must be between 3 and 15 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(3).WithMessage("Password must be at least 3 characters");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Passwords must be match.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.").EmailAddress()
                .WithMessage("Invalid email format.");

            RuleFor(x => x.ConfirmEmail)
                .Equal(x => x.Email).WithMessage("Emails must match.");
        }
    }
}
