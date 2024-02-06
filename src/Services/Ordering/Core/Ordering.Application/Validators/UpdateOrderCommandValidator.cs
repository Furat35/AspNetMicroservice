﻿using FluentValidation;
using Ordering.Application.Features.Orders.Commands.UpdateOrder;

namespace Ordering.Application.Validators
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(o => o.UserName)
                .NotEmpty().WithMessage("{Username} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{Username} must not exceed 50 characters");

            RuleFor(o => o.EmailAddress)
                .NotEmpty().WithMessage("{EmailAddress} is required");

            RuleFor(o => o.TotalPrice)
                .NotEmpty().WithMessage("{TotalPrice} is required.")
                .GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");
        }
    }
}