namespace Api.Authorization.Model.Interfaces;

public interface IRole
{
    Guid? Id { get; set; }
    string? Name { get; set; }
}