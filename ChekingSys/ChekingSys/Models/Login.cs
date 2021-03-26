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
        public string Username { get; set; }
        public int Password { get; set; }
    }
}
