using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        public bool Condition { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
