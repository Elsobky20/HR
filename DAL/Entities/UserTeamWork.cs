using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class UserTeamWork
    {
        public int Id { get; set; }
        public int? TeamworkId { get; set; }
        [ForeignKey("Id")]
        public Teamwork Teamwork { get; set; }
        public string UserId { get; set; }
        [ForeignKey("Id")]
        public virtual Users Users { get; set; }

    }
}
