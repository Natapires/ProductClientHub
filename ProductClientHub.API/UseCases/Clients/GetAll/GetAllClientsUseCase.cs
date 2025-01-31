using ProductClientHub.API.Infrastructure;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Clients.GetAll
{
    public class GetAllClientsUseCase
    {
        public ResponseAllClientsJson Execute()
        {
            var dbContext = new ProductClientHubDbContext();

            var clients = dbContext.Clients.ToList();

            return new ResponseAllClientsJson
            {
                Clients = clients.Select(client => new ResponseShortClientJson
                {
                    Id = client.Id,
                    Name = client.Name,
                }). ToList()
            };
        }
    }
}