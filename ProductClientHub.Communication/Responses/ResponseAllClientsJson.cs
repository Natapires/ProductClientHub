namespace ProductClientHub.Communication.Responses;

public class ResponseAllClientsJson
{
    public IEnumerable<ResponseShortClientJson> Clients { get; set; } = [];
}