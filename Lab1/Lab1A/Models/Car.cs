using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// I, Zachary Sojnocki, 000367577, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
namespace Lab1A.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Make { get; set; }
        [Required]
        public String Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public String VIN { get; set; }
        public String Colour { get; set; }
        public int? DealershipID { get; set; }
    }
}
