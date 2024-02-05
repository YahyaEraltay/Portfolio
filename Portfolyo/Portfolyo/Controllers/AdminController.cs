using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdminController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var x = c.Resumes.OrderByDescending(x => x.ResumeID).FirstOrDefault();
            return View(x);
        }
        [HttpPost]
        public IActionResult Index(Resume p, IFormFile Photo)
        {
            if (Photo != null && Photo.Length > 0)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", uniqueFileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    Photo.CopyTo(stream);
                }
                p.Photo = uniqueFileName;
            }
            c.Resumes.Add(p);
            c.SaveChanges();
            return RedirectToAction("Skills");
        }
        public IActionResult Skills()
        {
            var x = c.Skills.ToList();
            return View(x);
        }
        [HttpGet]
        public IActionResult AddSKill()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddSKill(Skill p)
        {
            c.Skills.Add(p);
            c.SaveChanges();
            return RedirectToAction("Skills");
        }
        public IActionResult DeleteSkill(int id)
        {
            var status = c.Skills.Find(id);
            status.Status = false;
            c.SaveChanges();
            return RedirectToAction("Skills");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var skill = c.Skills.Find(id);
            return View(skill);

        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill p, int id)
        {
            var x = c.Skills.Find(id);
            x.SkillID = p.SkillID;
            x.SkillName = p.SkillName;
            x.SkillScore = p.SkillScore;
            c.SaveChanges();

            return RedirectToAction("Skills");

        }
        public IActionResult Education()
        {
            var edu = c.Educations.ToList();
            return View(edu);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education p)
        {
            c.Educations.Add(p);
            c.SaveChanges();
            return RedirectToAction("Education");
        }
        public IActionResult DeleteEducation(int id)
        {
            var x = c.Educations.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("Education");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var x = c.Educations.Find(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education p, int id)
        {
            var x = c.Educations.Find(id);
            x.EducationID = p.EducationID;
            x.EducationName = p.EducationName;
            x.EducationDescription = p.EducationDescription;
            c.SaveChanges();
            return RedirectToAction("Education");
        }
        public IActionResult Experience()
        {
            var x = c.Experiences.ToList();
            return View(x);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            c.Experiences.Add(p);
            c.SaveChanges();
            return RedirectToAction("Experience");
        }
        public IActionResult DeleteExperience(int id)
        {
            var x = c.Experiences.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("Experience");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var x = c.Experiences.Find(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience p, int id)
        {
            var x = c.Experiences.Find(id);
            x.ExperienceID = p.ExperienceID;
            x.ExperienceName = p.ExperienceName;
            x.ExperienceDescription = p.ExperienceDescription;
            c.SaveChanges();
            return RedirectToAction("Experience");
        }
        public IActionResult Project()
        {
            var x = c.Projects.ToList();
            return View(x);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Project p, IFormFile ProjectPhoto)
        {
            if (ProjectPhoto != null && ProjectPhoto.Length > 0)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + ProjectPhoto.FileName;
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", uniqueFileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ProjectPhoto.CopyTo(stream);
                }
                p.ProjectPhoto = uniqueFileName;
            }
            c.Projects.Add(p);
            c.SaveChanges();

            return RedirectToAction("Project");
        }
        public IActionResult DeleteProject(int id)
        {
            var x = c.Projects.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("Project");
        }
        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var x = c.Projects.Find(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult UpdateProject(Project p, int id, IFormFile ProjectPhoto)
        {
            if (ProjectPhoto != null && ProjectPhoto.Length > 0)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + ProjectPhoto.FileName;
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", uniqueFileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ProjectPhoto.CopyTo(stream);
                }
                p.ProjectPhoto = uniqueFileName;
            }
            var x = c.Projects.Find(id);
            x.ProjectID = p.ProjectID;
            x.ProjectAnnotation = p.ProjectAnnotation;
            x.ProjectLink = p.ProjectLink;
            x.ProjectPhoto = p.ProjectPhoto;
            c.SaveChanges();
            return RedirectToAction("Project");
        }
        public IActionResult Contact()
        {
            var x = c.Contacts.OrderByDescending(x => x.ContactID).ToList();
            return View(x);
        }
        public IActionResult Seen(int id)
        {
            var x = c.Contacts.Find(id);
            x.ReadReceipt = true;
            c.SaveChanges();
            return RedirectToAction("Contact");
        }
        public IActionResult Unseen(int id)
        {
            var x = c.Contacts.Find(id);
            x.ReadReceipt = false;
            c.SaveChanges();
            return RedirectToAction("Contact");
        }
    }
}
