using System;
using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{

    public class Visitor
    {
        [Required(ErrorMessage="Name is required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage="Name can only contain letters")]
        [Display(Name = "Name")]
        public string name { get; set; }
        
        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage="Please enter a valid email address")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage="Message is required")]
        [MinLength(10, ErrorMessage="Message must be at least 10 characters")]
        [Display(Name = "Message")]
        public string messageText { get; set; }      
    }

}