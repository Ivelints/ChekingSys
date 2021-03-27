using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChekingSys.Models
{
    public class Worker
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Name Surname")]
        [Required]
        public string NamеSurname  { get; set; }
        [Required]
        public string Position { get; set; }
        /*public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M4 { get; set; }
        public string M5 { get; set; }
        public string M6 { get; set; }
        public string M7 { get; set; }
        public string M8 { get; set; }
        public string M9 { get; set; }
        public string M10 { get; set; }
        public string M11 { get; set; }
        public string M12 { get; set; }
        public string M13 { get; set; }
        public string M14 { get; set; }
        public string M15 { get; set; }
        public string M16 { get; set; }
        public string M17 { get; set; }
        public string M18 { get; set; }
        public string M19 { get; set; }
        public string M20 { get; set; }
        public string M21 { get; set; }
        public string M22 { get; set; }
        public string M23 { get; set; }
        public string M24 { get; set; }
        public string M25 { get; set; }
        public string M26 { get; set; }
        public string M27 { get; set; }
        public string M28 { get; set; }
        public string M29 { get; set; }
        public string M30 { get; set; }
        public string M31 { get; set; }
        public int Shift1 { get; set; }*/
        [Required]
        [Range(1, 2, ErrorMessage = "It must be first or second shift!")]
        public int Shift { get; set; }
        [DisplayName("Worked days")]
        [Required]
        [Range(1,31,ErrorMessage ="It must be the between the days in one month!")]
        public double Workedays { get; set; }
        /*public int MonthlyRate { get; set; }
        public int RegularLeave { get; set; }
        public int UnpaidLeave { get; set; }
        public int Motherhood { get; set; }
        public int Illness { get; set; }
        public int HolidaysВeekends { get; set; }
        public double Overtime { get; set; }*/
    }
}
