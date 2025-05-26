using Cyberius.Transcoder.IdentityApi.Application.DTO.Requests;
using FluentValidation;

namespace Cyberius.Transcoder.IdentityApi.Application.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Эл. почта не заполнена.")
            .EmailAddress().WithMessage("Эл. почта заполнена неправильно.");
        
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Пароль не заполнен.")
            .MinimumLength(6).WithMessage("Пароль должен содержать не менее 6 символов.")
            .MaximumLength(100).WithMessage("Пароль должен содержать не более 100 символов.");
    }
}
