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
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}