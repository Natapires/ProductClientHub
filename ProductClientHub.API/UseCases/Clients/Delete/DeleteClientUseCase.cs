using ProductClientHub.API.Infrastructure;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductClientHub.API.UseCases.Clients.Delete;

public class DeleteClientUseCase
{
    public void Execute(Guid id)
    {
        var dbContext = new ProductClientHubDbContext();

        var entity = dbContext.Clients.FirstOrDefault(client => client.Id == id);
        if (entity is null)
        {
            throw new NotFoundException("O Cliente não foi encontrado.");
        }

        dbContext.Clients.Remove(entity);
        dbContext.SaveChanges();
    } 
}