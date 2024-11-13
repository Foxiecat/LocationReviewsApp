using API.Features.Location.DTO;

namespace API.Features.Location.Interfaces;

// TODO: Add Update and Delete Tasks
public interface ILocationService
{
    Task<LocationResponse?> AddLocationAsync(LocationRequest request);
    Task<LocationResponse?> GetLocationByIdAsync(Guid id);
}