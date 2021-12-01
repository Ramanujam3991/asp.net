using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataValidation.Models
{
    public class Movie
    {
        [StringLength(10,
 ErrorMessage = "Name must be 10 characters or less.")]

        [Required(ErrorMessage = "Name is invalid")]
        public string Name { get; set; }
        [Range(1, 5, ErrorMessage = "Please enter a rating between 1 and 5.")]
        public int Rating { get; set; }
    }
}
