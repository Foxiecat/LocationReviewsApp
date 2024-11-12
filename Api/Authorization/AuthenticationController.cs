using Api.Authorization.DTO;
using Api.Features.Account.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api.Authorization;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController(UserManager<IdentityUser> userManager,
                                      TokenService tokenService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] AccountRequest model)
    {
        IdentityUser user = new() { UserName = model.UserName, Email = model.Email };
        IdentityResult result = await userManager.CreateAsync(user, model.Password);
        
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok("User registered");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO model)
    {
        IdentityUser? user = await userManager.FindByNameAsync(model.Username);
        if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
        {
            string token = tokenService.GenerateToken(user);
            return Ok(new { token });
        }
        
        return Unauthorized("Invalid username or password");
    }
}