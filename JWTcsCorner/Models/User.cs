using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smaAPI.Models
{
    [Table("Users", Schema = "SMA")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(21, MinimumLength = 4)] 
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Permission { get; set; }
        //public string Email { get; set; }
        //public string? first_name { get; set; }
        //public string? last_name { get; set; }
        //public uint? phone_number { get; set; }
    }
}
