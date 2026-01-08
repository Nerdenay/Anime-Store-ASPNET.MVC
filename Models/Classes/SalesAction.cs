using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class SalesAction
    {
        [Key]
        public int SaleId { get; set; }    
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal price { get; set; }
        public decimal TotalSale { get; set; }

		[ForeignKey("Products")] // ForeignKey tanımlama
		public int ProductID { get; set; }

		[ForeignKey("Currents")] // ForeignKey tanımlama
		public int CurrentID { get; set; }

		[ForeignKey("Employee")] // ForeignKey tanımlama
		public int EmployeeID { get; set; }

		public virtual Products Products { get; set; }

		public virtual Currents Currents { get; set; }

		public virtual Employee Employee { get; set; }

    }
}
