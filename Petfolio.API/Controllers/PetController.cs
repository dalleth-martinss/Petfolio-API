using Microsoft.AspNetCore.Mvc;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    public IActionResult Register()
    {
        return Created();
    }
}
