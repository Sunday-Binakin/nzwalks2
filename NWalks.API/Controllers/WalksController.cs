using Microsoft.AspNetCore.Mvc;
using NWalks.API.Models.Domain;

namespace NWalks.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WalksController:ControllerBase
{
    [HttpGet]
    
    public IActionResult GetAll()
    {
        var walks = new List<Walk>
        {
            new Walk
            {
                Id = Guid.NewGuid(),
                Name = "long walk",
                walkimageUrl = "https://image2"
            }
        };

        return Ok(walks);
    }
}