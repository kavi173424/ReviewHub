using FluentValidation;
using ReviewHubOrchestrationAPI.Models;

namespace ReviewHubOrchestrationAPI.Validators
{
    public class ReviewValidator : AbstractValidator<ReviewRequestModel>
    {
        public ReviewValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Product name is required.");

            RuleFor(x => x.Platform)
                .NotEmpty().WithMessage("Platform name is required.");
        }
    }
}