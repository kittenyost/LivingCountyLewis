using System;
using System.ComponentModel.DataAnnotations;

namespace LivingCountyLewisAPI.Models
{
    public class EmailLead
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? Area { get; set; }  // ✅ New field for area number
        public string? Message { get; set; }  // ✅ New field for message

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}