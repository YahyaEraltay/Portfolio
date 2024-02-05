using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Models
{
    public class Resume
    {
        [Key]
        public int ResumeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string LinkedinLink { get; set; }
        public string GithubLink { get; set; }
        public string InstagramLink { get; set; }
    }
}
