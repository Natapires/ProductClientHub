using System.Net;

namespace ProductClientHub.Exceptions.ExceptionBase;

public abstract class ProductClientHubException : SystemException
{
    public ProductClientHubException(string errorMessage) : base(errorMessage) //Estou chamando o construtor da classe que eu estou herdando.
    {
    }

    public abstract List<string> GetErrors();
    public abstract HttpStatusCode GetHttpStatusCode();

}