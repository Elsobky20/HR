using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Entities
{
    public class AttendanceAndLeave
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeOfAttendance { get; set; }
        public TimeSpan TimeOfLeave { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]
        public Employee Employee { get; set; }

    }
}
