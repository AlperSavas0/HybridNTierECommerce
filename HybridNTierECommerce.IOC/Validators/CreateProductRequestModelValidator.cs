using FluentValidation;
using HybridNTıerECommerce.VIEWMODEL.ViewModels.ProductVMs.PureVMs.RequrestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.IOC.Validators
{
    public class CreateProductRequestModelValidator : AbstractValidator<CreateProductRequestModel>
    {
        public CreateProductRequestModelValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Product name is required")
                .MaximumLength(20).WithMessage("Product name can not exceed 20 characters");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("Price is required")
                .GreaterThan(0).WithMessage("Price must be greater than zero");

            RuleFor(x => x.UnitsInStock)
                .NotEmpty().WithMessage("Units in stock is required")
                .GreaterThanOrEqualTo(0).WithMessage("Units in stock can not be less than zero");

        }
    }
}
