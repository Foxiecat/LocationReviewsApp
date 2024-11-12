using Api.Authorization.Model.Interfaces;

namespace Api.Authorization.Model;

public class IdentityUser : IIdentityUser
{
    public Guid? Id { get; set; }
    public string? UserName { get; set; }
    public ICollection<IRole> Roles { get; set; }
}