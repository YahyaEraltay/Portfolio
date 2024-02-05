using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7V7GQ23; User Id=sa; Password=yahyabey308; database=Portfolio_DB; integrated security=true;");
        }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
