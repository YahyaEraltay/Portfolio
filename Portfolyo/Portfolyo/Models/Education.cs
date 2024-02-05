using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string EducationName { get; set; }
        public string EducationDescription { get; set; }
        public bool Status { get; set; } = true;
    }
}
