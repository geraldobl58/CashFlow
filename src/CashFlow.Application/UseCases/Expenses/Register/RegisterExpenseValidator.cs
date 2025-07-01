using FluentValidation;
using CashFlow.Communication.Requests;
using CashFlow.Exception;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
    {
        public RegisterExpenseValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(ResourceErrorMessages.TITLE_REQUIRED);
            RuleFor(x => x.Amount)
                .GreaterThan(0)
                .WithMessage(ResourceErrorMessages.AMOUNT_MUST_BE_GREATHER_THAN_ZERO);
            RuleFor(x => x.Date)
                .LessThanOrEqualTo(DateTime.UtcNow)
                .WithMessage(ResourceErrorMessages.EXPENSES_CANNOUT_FOR_THE_FUTERE);
            RuleFor(x => x.PaymentType)
                .IsInEnum()
                .WithMessage(ResourceErrorMessages.PAYMENT_TYPE_INVALID);
        }
    }
}
