using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id {get; set;}

        [Required(ErrorMessage="Department name is required.")]
        public string DepartmentName {get;  set;}
        public float Salary { get; set;}
    }
}
