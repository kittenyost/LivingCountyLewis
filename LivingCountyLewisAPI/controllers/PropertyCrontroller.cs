using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]  // ✅ This makes it available at `/api/property`
public class PropertyController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProperties()
    {
        return Ok(new { message = "API is working!" });
    }
}