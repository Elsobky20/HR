using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public int? TeamworkId { get; set; }
        [ForeignKey("Id")]
        public Teamwork Teamwork { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }

    }
}
