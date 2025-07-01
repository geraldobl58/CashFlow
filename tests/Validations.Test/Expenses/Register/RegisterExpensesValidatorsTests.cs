using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validations.Test.Expenses.Register
{
    public class RegisterExpensesValidatorsTests
    {
        [Fact]
        public void Success()
        {
            // Arrange
            var validator = new RegisterExpenseValidator();
            var request = new RequestRegisterExpenseJson
            {
                Amount = 100,
                Date = DateTime.Now,
                Description = "Test expense",
                Title = "Test Title",
                PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.True(result.IsValid, "Validation should succeed for valid request.");
        }
    }
}
