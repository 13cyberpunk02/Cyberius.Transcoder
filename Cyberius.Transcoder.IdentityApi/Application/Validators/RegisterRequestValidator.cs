using Cyberius.Transcoder.IdentityApi.Application.DTO.Requests;
using FluentValidation;

namespace Cyberius.Transcoder.IdentityApi.Application.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Эл. почта не заполена.")
            .EmailAddress().WithMessage("Эл. почта заполнена неправильно.");
        
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Пароль не заполен.")
            .MinimumLength(6).WithMessage("Пароль должен содержать минимум 6 символов.")
            .Matches(@"[A-Z]").WithMessage("Пароль должен содержать хотя бы одну заглавную букву.")
            .Matches(@"[a-z]").WithMessage("Пароль должен содержать хотя бы одну строчную букву.")
            .Matches(@"[0-9]").WithMessage("Пароль должен содержать хотя бы одну цифру.")
            .Matches(@"[\W_]").WithMessage("Пароль должен содержать хотя бы один специальный символ.");

        RuleFor(x => x.ConfirmPassword)
            .NotEmpty().WithMessage("Подтверждение пароля не заполнено.")
            .Equal(x => x.Password).WithMessage("Пароли не совпадают.");
    }
}
