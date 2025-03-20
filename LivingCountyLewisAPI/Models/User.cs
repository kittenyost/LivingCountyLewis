namespace LivingCountyLewisAPI.Models
{
    public class User
    {
        public int Id { get; set; }  // ✅ Unique Identifier (Primary Key)
        public string? Name { get; set; }  // ✅ Allows Name to be null
        public string? Email { get; set; } // ✅ Allows Email to be null
    }
}