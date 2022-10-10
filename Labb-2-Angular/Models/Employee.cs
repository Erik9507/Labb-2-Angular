using System.ComponentModel.DataAnnotations;

namespace Labb_2_Angular.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        
        public string Email { get; set; }

        
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

        
        public string Adress { get; set; }

        
        public string Title { get; set; }
        public double MonthSalary { get; set; }
        public bool Admin { get; set; }



        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
