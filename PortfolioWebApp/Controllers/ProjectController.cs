using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            var projects = ProjectStorage.Projects;
            return View(projects);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Project project)
        {
            ProjectStorage.Add(project);

            return RedirectToAction("Index");
        }

        public IActionResult Remove(string name)
        {
            ProjectStorage.RemoveByName(name);

            return RedirectToAction("Index");
        }
    }
}
