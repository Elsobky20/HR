using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class GroupPages
    {
        public int Id { get; set; }
        public bool Create { get; set; }
        public bool Edite { get; set; }
        public bool Delelte { get; set; }
        public bool Show { get; set; }
        public int? TeamworkId { get; set; }
        [ForeignKey("Id")]
        public Teamwork Teamwork { get; set; }
        public int? PagesId { get; set; }
        [ForeignKey("Id")]
        public Pages Pages { get; set; }
    }
}
