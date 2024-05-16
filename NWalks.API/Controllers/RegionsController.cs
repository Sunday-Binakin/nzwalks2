using Microsoft.AspNetCore.Mvc;
using NWalks.API.Models.Domain;

namespace NWalks.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class RegionsController: ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var region = new List<Region>
        {
            new Region
            {
                Id = Guid.NewGuid(),
                Name = "Auckland Region",
                RegionImageUrl = "http://images1"
            },
            new Region
            {
                Id = Guid.NewGuid(),
                Name = "Wellington Region",
                RegionImageUrl = "http://images2"
            }
        };
        return Ok(region);
    }
}