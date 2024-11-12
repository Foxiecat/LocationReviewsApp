using Microsoft.AspNetCore.Identity;

namespace Api.Authorization;

public class UserSeeder(RoleManager<IdentityRole> roleManager,
                        UserManager<IdentityUser> userManager)
{
    public async Task SeedUserAsync()
    {
        
    }
}