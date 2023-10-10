using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BankSystemAPI.Models
{
    public class User
    {
        [Key]
        [JsonIgnore]
        public int user_Id { get; set; }
        
        [Required]
        [JsonIgnore]
        public string Name { get; set; }
        
        [Required]
        public string Password { get; set; }
      
        [Required]
        public string Email { get; set; }
       
        [JsonIgnore]
        public List<Account> accounts { get; set; }
    }
}
