namespace smaAPI.Models
{
    public enum Tier 
    { 
        Admin, // 
        User //
    };

    public class Role
    {
        public int Id { get; set; }
        public Tier tier { get; set; }
    }
}
