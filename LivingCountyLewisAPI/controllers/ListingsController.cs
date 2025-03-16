using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ListingsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetListings()
    {
        var listings = new List<object>
        {
            new { Title = "Modern Family Home", Price = 350000, Description = "A beautiful 3-bedroom home in a quiet neighborhood.", Image = "https://source.unsplash.com/featured/?house" },
            new { Title = "Luxury Villa", Price = 950000, Description = "A luxurious villa with a private pool and sea view.", Image = "https://source.unsplash.com/featured/?villa" },
            new { Title = "Cozy Cabin in the Woods", Price = 220000, Description = "A peaceful retreat surrounded by nature.", Image = "https://source.unsplash.com/featured/?cabin" }
        };

        return Ok(listings);
    }
}