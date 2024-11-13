using API.Features.Location.DTO;
using API.Features.Location.Interfaces;

namespace API.Features.Location;

public class LocationService(ILogger<LocationService> logger) : ILocationService
{
    // TODO
    public Task<LocationResponse?> AddLocationAsync(LocationRequest request)
    {
        throw new NotImplementedException();
    }

    // TODO
    public Task<LocationResponse?> GetLocationByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}