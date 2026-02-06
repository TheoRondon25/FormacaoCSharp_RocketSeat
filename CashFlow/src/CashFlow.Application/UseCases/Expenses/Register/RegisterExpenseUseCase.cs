using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        return new ResponseRegisteredExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        List<string> errors = new List<string>();

        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
        if (titleIsEmpty)
        {
            //throw new ArgumentException("the title is required.");
            errors.Add("the title is required.");
        }

        if(request.Amount <= 0)
        {
            //throw new ArgumentException("The Amount must be greater than zero.");
            errors.Add("The Amount must be greater than zero.");
        }

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);
        if(result > 0)
        {
            //throw new ArgumentException("The date cannot be in the future.");
            errors.Add("The date cannot be in the future.");
        }

        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
        if (paymentTypeIsValid == false)
        {
            //throw new ArgumentException("Payment Type is not valid.");
            errors.Add("Payment Type is not valid.");
        }

        if (errors.Count > 0)
        {
            throw new ArgumentException(string.Join(" ", errors));
        }
    }
}
