using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionBase;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CashFlow.Exception;

namespace CashFlow.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if(context.Exception is CashFlowException)
        {
            HandleProjectException(context);
        } 
        else
        {
            ThrowUnkowError(context);
        }
    }

    private void HandleProjectException(ExceptionContext context)
    {
        var cashFlowException = context.Exception as CashFlowException;
        var errorResponse = new ResponseErrorJson(cashFlowException!.GetErrors());

        context.HttpContext.Response.StatusCode = cashFlowException.StatusCode;
        context.Result = new ObjectResult(errorResponse);        
    }

    private void ThrowUnkowError(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson(ResourceErrorMessages.UNKNOWN_ERROR);

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);       
    }
}
