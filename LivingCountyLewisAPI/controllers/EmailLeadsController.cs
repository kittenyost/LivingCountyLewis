using Microsoft.AspNetCore.Mvc;
using LivingCountyLewisAPI.Data;
using LivingCountyLewisAPI.Models;
using System.Threading.Tasks;
using System;

namespace LivingCountyLewisAPI.Controllers
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
            {
                Console.WriteLine("❌ Invalid model");
                return BadRequest(ModelState);
            }

            try
            {
                _context.EmailLeads.Add(emailLead);
                await _context.SaveChangesAsync();
                Console.WriteLine($"✅ Saved email: {emailLead.Email}");
                return Ok(new { message = "Email saved successfully!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"🚨 Exception: {ex.Message}");
                return StatusCode(500, "Server error");
            }
        }
    }
}