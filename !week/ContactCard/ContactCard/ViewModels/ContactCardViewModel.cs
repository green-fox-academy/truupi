using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactCardApp.ViewModels
{
    public class ContactCardViewModel
    {
        public long Id { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "You have to enter!")]
        [MinLength(2, ErrorMessage = "The First Name field must contain at least 2 characters!")]
        [MaxLength(50, ErrorMessage = "The First Name field cannot contain more than 50 characters!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The Last Name field must contain at least 2 characters!")]
        [MaxLength(50, ErrorMessage = "The Last Name field cannot contain more than 50 characters!")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The Last Name field must contain at least 2 characters!")]
        [MaxLength(50, ErrorMessage = "The Last Name field cannot contain more than 50 characters!")]
        public string Job { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The Last Name field must contain at least 2 characters!")]
        [MaxLength(50, ErrorMessage = "The Last Name field cannot contain more than 50 characters!")]
        public string CompanyName { get; set; }

        [Phone(ErrorMessage = "Phone number must be a valid number!")]
        public string PhoneNum { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email must be a valid email address!")]
        public string EmailAddress { get; set; }

        public string WebAddress { get; set; }
        public string ImageLink { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string TwitterLink { get; set; }
    }
}
