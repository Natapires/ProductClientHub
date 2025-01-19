using System.Net;

namespace ProductClientHub.Exceptions.ExceptionBase;

public class ErrorOnValidatioException : ProductClientHubException
{
    private readonly List<string> _errors; //so pode ser alterado/adicionado dentro do construtor da classe. 
    public ErrorOnValidatioException(List<string> errorMessages) : base(string.Empty)
    {
        _errors = errorMessages;
    }

    public override List<string> GetErrors() => _errors;

    public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.BadRequest;
}