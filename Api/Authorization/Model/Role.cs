using Api.Authorization.Model.Interfaces;

namespace Api.Authorization.Model;

public class Role : IRole
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
}