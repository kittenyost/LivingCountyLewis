using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LivingCountyLewisAPI.Models;  // ✅ Ensure you import your `User` model

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private static List<User> users = new()
    {
        new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
        new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
    };

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(users);
    }
}
