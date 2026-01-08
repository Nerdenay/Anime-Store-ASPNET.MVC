using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Staj_Projesi_1.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string EmployeePic { get; set; }

        public int DepartmentID { get; set; }
        public  Department Department { get; set; }

        public virtual ICollection<SalesAction> SalesActions { get; set; }
    }
}
