using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class IdentityController : ControllerBase
{
    public IActionResult Get()
    {
        var result = from c in User.Claims select new { c.Type, c.Value };
        return new JsonResult(result);
    }
}