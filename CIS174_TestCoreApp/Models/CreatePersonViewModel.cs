using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [MaxLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage = "Email and Confirmation Email must match.")]
        public string ConfirmEmail { get; set; }

        [Url]
        [DataType(DataType.Url)]
        [MinLength(7)]
        public string Website { get; set; }

        [Editable(false)]
        public string School { get; set; } 
    }
}
