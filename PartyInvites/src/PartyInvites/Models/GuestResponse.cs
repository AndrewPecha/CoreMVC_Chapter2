using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "But I need to know your name!")]
        public string  Name { get; set; }
        [Required (ErrorMessage = "Gonna need your email address in case of cancellation..")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "That's not a real email address, regex")]
        //[EmailAddress (ErrorMessage = "That's not a real Email Address")]
        public string Email { get; set; }
        [Required (ErrorMessage = "What if I wanna be that friend that drunkenly calls you at 2 AM? GIMME YOUR NUMBAH!")]
        public string Phone { get; set; }
        [Required (ErrorMessage = "K but really, I need to know if you'll be there or not")]
        public bool? WillAttend { get; set; }

    }
}
