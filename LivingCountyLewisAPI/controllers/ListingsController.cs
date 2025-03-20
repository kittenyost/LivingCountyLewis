using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class ListingsController : ControllerBase
{
    private static readonly List<dynamic> listings = new()
    {
        new { Id = 1, Title = "Modern Family Home", Price = 350000, Description = "A beautiful 3-bedroom home.", Image = "https://source.unsplash.com/featured/?house" },
        new { Id = 2, Title = "Luxury Villa", Price = 950000, Description = "A luxurious villa with a private pool.", Image = "https://source.unsplash.com/featured/?villa" },
        new { Id = 3, Title = "Cozy Cabin", Price = 220000, Description = "A peaceful retreat in the woods.", Image = "https://source.unsplash.com/featured/?cabin" }
    };

    // ✅ Get all listings
    [HttpGet]
    public IActionResult GetListings()
    {
        return Ok(listings);
    }

    // ✅ Get a listing by ID
    [HttpGet("{id}")]
    public IActionResult GetListingById(int id)
    {
        var listing = listings.FirstOrDefault(l => l.Id == id);
        if (listing == null) return NotFound();
        return Ok(listing);
    }
} // ✅ This is the final closing bracket for the class