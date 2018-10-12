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
    public class Member
    {
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Key]
        public String UserName { get; set; }
        [Required]
        public String Email { get; set; }
        public String Company { get; set; }
        public String Position { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
