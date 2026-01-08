using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Staj_Projesi_1.Models.Classes
{
    public class Outgoings
    {
        [Key] 
        public int OutgoingId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string OutgoingExp { get; set; }
        public DateTime Date {  get; set; }
        public decimal Sum { get; set; } // Tutar 

    }
}
