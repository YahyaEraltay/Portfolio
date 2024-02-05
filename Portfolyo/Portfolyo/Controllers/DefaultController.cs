using Microsoft.AspNetCore.Mvc;
using Portfolyo.Models;
using Portfolyo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var resume = c.Resumes.OrderByDescending(x=>x.ResumeID).FirstOrDefault();
            var skill = c.Skills.ToList();
            var edu = c.Educations.ToList();
            var exp = c.Experiences.ToList();
            var project = c.Projects.ToList();
            var viewModel = new ResumeSkillViewModel
            {
                Resume = resume,
                Skills = skill,
                Educations = edu,
                Experiences=exp,
                Projects=project
            };

            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            c.Contacts.Add(model);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
