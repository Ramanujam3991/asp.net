using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataValidation.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Enter customer name")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Name may not contain special characters.")]

        public string Name { get; set; }
        [Required(ErrorMessage ="Enter Date of Birth")]
        [Range(typeof(DateTime),"1/1/1980","12/12/2020", ErrorMessage ="Value must be in range")]
        public DateTime? DOB { get; set; }
        [Required(ErrorMessage ="Enter password")]
        [StringLength(15)]
        public string Password { get; set; }

        [StringLength(15)]
        [Compare("Password",ErrorMessage ="Password does not match")]
        [Required(ErrorMessage = "Enter Confirm password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
