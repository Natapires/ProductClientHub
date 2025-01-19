using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome nao pode ser vazio");
        RuleFor(client => client.Email).EmailAddress().WithMessage("Este e-mail nao e valido.");
    }
}