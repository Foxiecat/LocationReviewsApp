using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Authorization.Model.Interfaces;
using Api.Authorization.Services.Interfaces;
using Api.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Api.Authorization;

public class TokenService(IOptions<JwtOptions> jwtOptions) : ITokenService
{
    public Task<IIdentityUser> LoginAsync(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GenerateJwtTokenAsync(IIdentityUser user)
    {
        throw new NotImplementedException();
    }
}