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
    public class Dealership
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
    }
}
