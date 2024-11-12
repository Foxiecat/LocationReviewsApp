namespace Api.Authorization.Model.Interfaces;

public interface IIdentityUser
{
    public Guid? Id { get; set; }
    public string? UserName { get; set; }
    public ICollection<IRole> Roles { get; set; }
}