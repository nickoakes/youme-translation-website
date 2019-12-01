using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace youme_website.Models
{
    public class FormViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name must be between 2 and 50 characters in length", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please ensure that the format of the email address you have entered is valid")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Subject must be between 2 and 50 characters in length", MinimumLength = 2)]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}