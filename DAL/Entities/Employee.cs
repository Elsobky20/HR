using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Index(nameof(SSN), IsUnique = true)]
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public double Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime TimeOfAttendancde { get; set; }
        public DateTime TimeOfLeave { get; set; }
        public DateTime WorkStartTime { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }
    }
}
