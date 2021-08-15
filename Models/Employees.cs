using System.ComponentModel.DataAnnotations;

namespace DatabaseWebApp.Models
{
    public class Employees
    {
        //A bit of format enforcing for Entity, so no NULL objects allowed, and max lenght set to something reasonable
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string EmployeeName { get; set; }
        [Required]
        [MaxLength(150)]
        public string EmployeePosition { get; set; }
        [Required]
        public int Salary { get; set; }

        public Employees()
        {


        }
    }
}
