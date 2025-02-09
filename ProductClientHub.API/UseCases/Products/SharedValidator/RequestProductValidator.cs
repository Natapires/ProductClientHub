using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator;

public class RequestProductValidator : AbstractValidator<RequestProductJson>
{
    public RequestProductValidator()
    {
        RuleFor(product => product.Name).NotEmpty()
            .WithMessage("O nome do produto é inválido, adicione um nome válido.");
        RuleFor(product => product.Brand).NotEmpty().WithMessage("A marca desse produto é inválido.");
        RuleFor(product => product.Price).GreaterThan(0).WithMessage("Preço para o produto e inválido.");
    }
}