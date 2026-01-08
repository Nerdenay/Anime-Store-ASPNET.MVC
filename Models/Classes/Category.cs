using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class Category
    {

        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public virtual string CategoryName { get; set; }
        public ICollection<Products> Productss { get; set; }
    }
}
