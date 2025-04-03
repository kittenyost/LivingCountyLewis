using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LewisCountyLiving.Models
{
    [Table("Listings")]  // ✅ Make sure this appears only once!
    public class Listing
    {
        [Key]  // ✅ Primary Key
        public int Id { get; set; }

        [Required]  // ✅ Required field
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string ImageUrl { get; set; }
    }
}