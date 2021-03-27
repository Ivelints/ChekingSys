using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChekingSys.Models
{
    public class Login
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "You need to provide a username.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "You need to have a password")]
        [DataType(DataType.Password)]
        [StringLength(80, MinimumLength = 1, ErrorMessage = "You need to provide a long enough password.")]
        public string Password { get; set; }
    }
}
