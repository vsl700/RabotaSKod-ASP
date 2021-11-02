using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RabotaSKod_ASP.Models.ViewModel
{
    public class ContactsCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name can be at most 50 characters long")] 
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number")] 
        public string PhoneNumber { get; set; }

        [Required] [RegularExpression(@"^([\w‐\.]+)@((\[[0‐9]{1,3}\.[0‐9]{1,3}\.[0‐9]{1,3}\.)|(([\w‐
            ]+\.)+))([a‐zA‐Z]{2,4}|[0‐9]{1,3})(\]?)$", ErrorMessage = "Invalid email")] 
        public string Email { get; set; }

        public string Note { get; set; }

    }
}
