namespace LivingCountyLewisAPI.Models
{
    public class Listing
    {
        public int Id { get; set; }  // already exists
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // 🛏️ New Details You Want to Add
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double Acres { get; set; }
        public int YearBuilt { get; set; }
        public bool HasGarage { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
