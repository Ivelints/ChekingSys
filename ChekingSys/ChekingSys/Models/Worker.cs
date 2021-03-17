using System;
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
        public string NamеSurname  { get; set; }
        public string Position { get; set; }
        public string March1 { get; set; }
        public string March2 { get; set; }
        public string March3 { get; set; }
        public string March4 { get; set; }
        public string March5 { get; set; }
        public string March6 { get; set; }
        public string March7 { get; set; }
        public string March8 { get; set; }
        public string March9 { get; set; }
        public string March10 { get; set; }
        public string March11 { get; set; }
        public string March12 { get; set; }
        public string March13 { get; set; }
        public string March14 { get; set; }
        public string March15 { get; set; }
        public string March16 { get; set; }
        public string March17 { get; set; }
        public string March18 { get; set; }
        public string March19 { get; set; }
        public string March20 { get; set; }
        public string March21 { get; set; }
        public string March22 { get; set; }
        public string March23 { get; set; }
        public string March24 { get; set; }
        public string March25 { get; set; }
        public string March26 { get; set; }
        public string March27 { get; set; }
        public string March28 { get; set; }
        public string March29 { get; set; }
        public string March30 { get; set; }
        public string March31 { get; set; }
        public int Shift1 { get; set; }
        public int Shift2 { get; set; }
        public double workedays { get; set; }
        public int MonthlyRate { get; set; }
        public int RegularLeave { get; set; }
        public int UnpaidLeave { get; set; }
        public int Motherhood { get; set; }
        public int Illness { get; set; }
        public int ХolidaysВeekends { get; set; }
        public double Overtime { get; set; }
    }
}
