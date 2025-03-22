using Microsoft.AspNetCore.Mvc;
using LivingCountyLewisAPI.Data;
using LivingCountyLewisAPI.Models;

namespace YourProjectNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailLeadsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmailLeadsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostEmailLead([FromBody] EmailLead emailLead)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.EmailLeads.Add(emailLead);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Email saved successfully!" });
        }
    }
}