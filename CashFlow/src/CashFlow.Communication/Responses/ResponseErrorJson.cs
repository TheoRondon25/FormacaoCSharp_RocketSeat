namespace CashFlow.Communication.Responses;
public class ResponseErrorJson
{
    public string ErrorMessage { get; set; } = string.Empty;

    // outro modo de garantir que a mensagem de erro seja sempre recebida, é utilizando o rquired: (apenas em versoes mais novas)
    // public required string ErrorMessage { get; set; } = string.Empty;

    public ResponseErrorJson(string errorMessage) // CONSTRUTOR para garantir que sempre recebe a mensagem de erro.
    {
        ErrorMessage = errorMessage;
    }
}
