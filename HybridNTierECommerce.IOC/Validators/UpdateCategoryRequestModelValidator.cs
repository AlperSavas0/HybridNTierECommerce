using FluentValidation;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.CategoryVMs.PureVMs.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.Validators
{
    public class UpdateCategoryRequestModelValidator : AbstractValidator<UpdateCategoryRequestModel>
    {
        public UpdateCategoryRequestModelValidator()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("Category name is required")
                .MaximumLength(20).WithMessage("Category name can not be exceed 20 characters");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Desription is required")
                .MaximumLength(40).WithMessage("Description can no be exceed 40 characters");
        }
    }
}
