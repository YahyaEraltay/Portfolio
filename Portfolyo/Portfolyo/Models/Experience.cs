using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string ExperienceName { get; set; }
        public string ExperienceDescription { get; set; }
        public bool Status { get; set; } = true;
    }
}
