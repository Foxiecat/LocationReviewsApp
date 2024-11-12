using Api.Authorization.Model.Interfaces;

namespace Api.Authorization.Services.Interfaces;

public interface ITokenService
{
    Task<IIdentityUser> LoginAsync(string username, string password);
    Task<string?> GenerateJwtTokenAsync(IIdentityUser user);
}