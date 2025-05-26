namespace Cyberius.Transcoder.IdentityApi.Domain.Entities;

public class Role
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<UserRole> UserRoles { get; set; } = [];
}
