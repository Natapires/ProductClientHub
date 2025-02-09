using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Infrastructure;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductClientHub.API.UseCases.Clients.GetById;

public class GetClientByIdUseCase
{
    public ResponseClientJson Execute(Guid id)
    {
        var dbContext = new ProductClientHubDbContext();

        var entity = dbContext.Clients.Include(client => client.Products).FirstOrDefault(client => client.Id == id); //Estou utilizando o include para incluir os produtos ao cliente.
        if (entity is null)
        {
            throw new NotFoundException("O cliente nao foi encontrado.");
        }

        return new ResponseClientJson()
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            Products = entity.Products.Select(product => new ResponseShortProductJson //Para cada produto, estou criando uma resposta.
            {//Preenchendo as informacoes do produto.
                Id = product.Id,
                Name = product.Name,
            }).ToList()
        };
    }
}