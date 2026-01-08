using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class Invoice
    {

        [Key]
        public int InvoiceID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string InvoiceSerialNo { get; set; } // seri No

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string InvoiceSequenceNo { get; set; }  // sıra no 
        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }
        public DateTime InvoiceTime { get; set; } // fature kesilme saati

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Deliverer { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }

        public ICollection<InvoiceItems> InvoiceItemss { get; set; }


    }
}
