using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator;

public class RequestProductValidator : AbstractValidator<RequestProductJson>
{
    public RequestProductValidator()
    {
        RuleFor(product => product.Name).NotEmpty()
            .WithMessage("O nome do produto e invalido, adicione um nome valido.");
        RuleFor(product => product.Brand).NotEmpty().WithMessage("A marca desse produto e invalido.");
        RuleFor(product => product.Price).GreaterThan(0).WithMessage("Preco para o produto e invalido.");
    }
}