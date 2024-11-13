using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class DatabaseServiceExtension
{
    public static void AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LocationReviewsDbContext>(options => 
            options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 4, 2))));
    }
}