using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
        {
            Validate(request);

            return new ResponseRegisterExpenseJson();
        }

        private void Validate(RequestRegisterExpenseJson request)
        {
            var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);

            if (titleIsEmpty)
            {
                throw new ArgumentException("Title is required.", nameof(request.Title));
            }

            if (request.Amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.", nameof(request.Amount));
            }

            var result = DateTime.Compare(request.Date, DateTime.UtcNow);

            if (result > 0)
            {
                throw new ArgumentException("Date cannot be in the future.", nameof(request.Date));
            }

            var paymentTypeIsInvalid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);

            if (!paymentTypeIsInvalid)
            {
                throw new ArgumentException("Invalid payment type.", nameof(request.PaymentType));
            }
        }
    }
}
