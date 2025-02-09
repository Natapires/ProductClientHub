using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RequestClientValidator : AbstractValidator<RequestClientJson>
{
    public RequestClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vázio");
        RuleFor(client => client.Email).EmailAddress().WithMessage("Este e-mail não é válido.");
    }
}