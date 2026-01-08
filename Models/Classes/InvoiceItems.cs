using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class InvoiceItems
    {
        [Key]
        public int InvoiceItemID { get; set; } // yani faturanın alt kısmında dikdörtgen şekilde olan kısımlardır 

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; } // Birim Fiyat 
        public decimal Total { get; set; }  // Tutar 

        public Invoice Invoice { get; set; }
    }
}
