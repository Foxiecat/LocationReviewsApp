using API.Features.Location.DTO;
using API.Features.Location.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.Location;

[ApiController]
[Route("api/[controller]")]
public class LocationController(ILogger<LocationController> logger, ILocationService locationService) : ControllerBase
{
    [HttpPost(Name = "AddLocationAsync")]
    public async Task<ActionResult<LocationResponse>> AddLocationAsync([FromBody] LocationRequest request)
    {
        LocationResponse? locationResponse = await locationService
    }
}