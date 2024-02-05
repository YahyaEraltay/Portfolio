using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectLink { get; set; }
        public string ProjectPhoto { get; set; }
        public string ProjectAnnotation { get; set; }
        public bool Status { get; set; } = true;
    }
}
