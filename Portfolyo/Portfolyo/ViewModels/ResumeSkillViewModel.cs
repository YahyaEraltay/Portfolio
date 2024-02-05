using Portfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewModels
{
    public class ResumeSkillViewModel
    {
        public Resume Resume { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Project> Projects { get; set; }
    }
}
