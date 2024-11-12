using Microsoft.AspNetCore.Identity;

namespace Api.Authorization;

public class RoleSeeder(RoleManager<IdentityRole> roleManager)
{
    public async Task SeedRolesAsync()
    {
        if (!await roleManager.RoleExistsAsync("Reviewer"))
        {
            await roleManager.CreateAsync(new IdentityRole("Reviewer"));
        }

        if (!await roleManager.RoleExistsAsync("User"))
        {
            await roleManager.CreateAsync(new IdentityRole("User"));
        }
    }
}