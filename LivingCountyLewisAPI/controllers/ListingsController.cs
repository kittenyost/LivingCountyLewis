using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class ListingsController : ControllerBase
{
    private static readonly List<dynamic> listings = new()
{
  new {
  Id = 1,
  Title = "Modern Family Home",
  Price = 385000,
  Area = "426",
  Address = "123 Maple Street, Centralia, WA",
  Description = "Spacious 3-bedroom home with updated kitchen, fenced backyard, and two-car garage.",
  Image = "https://your-consistent-url.com/modern-familyhome.jpg" // Replace this with the URL you want shown everywhere
}
   new {
  Id = 3,
  Title = "Cozy Cabin",
  Price = 239000,
  Area = "426",
  Address = "42 Pine Lane, Mountain View, CO",
  Description = "Rustic 2-bed, 1-bath cabin nestled in the pines — perfect weekend getaway.",
  https://images.unsplash.com/photo-1600585154035-7c6c4c3a32c3?ixlib=rb-4.0.3&auto=format&fit=crop&w=800&q=80
}
   // new {
     //   Id = 4,
       // Title = "Downtown Craftsman",
      //  Price = 315000,
      //  Area = "430",
      //  Description = "Charming craftsman-style home near shops, schools, and restaurants.",
      //  Image = "https://images.unsplash.com/photo-1600585153600-9cd7458bfc14?auto=format&fit=crop&w=800&q=80"
  //  }
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

    // ✅ Get listings by Area Number (like "426" for Centralia)
    [HttpGet("area/{areaNumber}")]
    public IActionResult GetListingsByArea(string areaNumber)
    {
        var filtered = listings.Where(l => l.Area == areaNumber).ToList();
        return Ok(filtered);
    }
} // ✅ This is the final closing bracket for the class