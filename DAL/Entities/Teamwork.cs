using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Teamwork
    {
        public int Id { get; set; }
        public string NameOfTeame { get; set; }
        public bool Create { get; set; }
        public bool Edite { get; set; }
        public bool Delelte { get; set; }
        public bool Show { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey("Id")]
        public Employee Employee { get; set; }
        public int? PublicSettingsId { get; set; }
        [ForeignKey("Id")]
        public PublicSettings PublicSettings { get; set; }
        public int? OfficialVacationsId { get; set; }
        [ForeignKey("Id")]
        public OfficialVacations OfficialVacations { get; set; }

    }
}
