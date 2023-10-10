using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BankSystemAPI.Models
{
    public class Account
    {
     [Key]
     public int AccountNumber { get; set; }
     public string holderName { get; set; }
     public decimal balance { get; set; }
      public User User { get; set; }
      public List<Transaction> transactions { get; set; }

        [ForeignKey("User")]
      public int user_Id { get; set; }

    }
}
