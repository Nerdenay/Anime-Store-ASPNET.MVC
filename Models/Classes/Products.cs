using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{

    // [Column(TypeName = "Varchar")]: Bu açıklama, ProductName ve ProductBrand gibi string türündeki verilerin veritabanında VARCHAR olarak saklanacağını belirtiyor.
    // SQL'de string türündeki veriler genellikle VARCHAR ya da NVARCHAR olarak saklanır, ve burada VARCHAR olarak belirlendi. 
    // [StringLength(30)]: Bu açıklama, ProductName ve ProductBrand property'si için maksimum uzunluğun 30 karakterle sınırlı olduğunu belirtir.  
    // veritabanında VARCHAR(30) şeklinde bir sütun oluşturur ve daha uzun veri girilmesini engeller.

    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "Varchar")] 
        [StringLength(30)]      
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductBrand { get; set; }

        public short Stock { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public bool Condition { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductPic { get; set; }

        public virtual Category Category { get; set; }  // To override

        public virtual ICollection<SalesAction> SalesActions { get; set; }
    }
}

