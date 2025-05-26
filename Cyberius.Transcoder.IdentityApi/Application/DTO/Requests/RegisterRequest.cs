namespace Cyberius.Transcoder.IdentityApi.Application.DTO.Requests;

public record RegisterRequest(string Email, string Password, string ConfirmPassword);
