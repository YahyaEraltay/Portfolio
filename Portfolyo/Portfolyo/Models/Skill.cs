using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public int SkillScore { get; set; }
        public bool Status { get; set; } = true;

    }
}
