using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class EmployeeVM
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [MinLength(14, ErrorMessage = "SSN Must Be 14 Number This is less than 14")]
        [MaxLength(14, ErrorMessage = "SSN Must Be 14 Number This is more than 14")]
        public string SSN { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [MinLength(11, ErrorMessage = "من فضلك ادخل رقم تليفون صحيح")]
        [MaxLength(11, ErrorMessage = "من فضلك ادخل رقم تليفون صحيح")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Address { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Range(0, double.MaxValue, ErrorMessage = "من فضلك ادخل راتب صحيح ")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DataType(DataType.DateTime)]
        [CustomHireDate(ErrorMessage = "يجب الا يقل عمر الموظف عن 20 سنة")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public DateTime TimeOfAttendancde { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public DateTime TimeOfLeave { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        //[CustomHireDate(ErrorMessage = "يجب الا يقل تاريخ العقد عن 2005/6/6")]

        public DateTime WorkStartTime { get; set; }
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        public class CustomHireDate : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                DateTime dateTime = Convert.ToDateTime(value);
                return dateTime.Year <= DateTime.Now.Year - 20;
            }
        }
    }
}
