﻿namespace Cyberius.Transcoder.IdentityApi.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string UserAvatar { get; set; } = string.Empty;
    public List<UserRole> UserRoles { get; set; } = [];
}
