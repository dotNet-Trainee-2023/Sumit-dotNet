using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class Employee
    {
        [Key]
        public int id {  get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Employee Name")]

        public string? Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Position")]
        public string Position { get; set; } = string.Empty;


		[Required]
		public double Salary { get; set; }
	}
}
