using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace BankSystemAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Transction_Id { get; set; }

    
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime dateTime { get; set; }
        public int SorAccId { get; set; }
        public int TarAccId { get; set; }
        public Account Account { get; set; }

        [ForeignKey ("account")]
        public int AccountNumber { get; set; }

  
     
            

    }
}
