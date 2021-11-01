using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace week2_single_page_application.Models
{
    public class Triangle
    {
        [Required(ErrorMessage="Please enter Height")]
        [Range(0,10000,ErrorMessage="Please enter a valid height between 0 and 10000")]
        public float? height { get; set; }

        [Required(ErrorMessage ="Please enter Breadth")]
        [Range(0,10000,ErrorMessage ="Please enter a valid Breadth between 0 and 10000")]
        public float? breadth { get; set; }

        public float? area() {
            return 0.5f * height * breadth;
        }
    }
}
