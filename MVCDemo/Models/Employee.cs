using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCDemo.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "name is required")]
        [Display(Name = "Employee full name")]
        [MaxLength(30, ErrorMessage = "Name must have less than 30 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email id is not in proper format")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Age is required")]
        [Range(18, 60, ErrorMessage = "Age must be in between 18 -60")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm Password does not match")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

    }
}
