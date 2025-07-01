using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;

namespace Validations.Test.Expenses.Register
{
    public class RegisterExpensesValidatorsTests
    {
        [Fact]
        public void Success()
        {
            // Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.True(result.IsValid, "Validation should succeed for valid request.");
        }
    }
}
