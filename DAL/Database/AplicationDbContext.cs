using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Database
{
   public class AplicationDbContext : IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OfficialVacations> OfficialVacations { get; set; }
        public DbSet<PublicSettings> PublicSettings { get; set; }
        public DbSet<Teamwork> Teamworks { get; set; }
        public DbSet<Users> Useres { get; set; }
    }
}
