using DashboardAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DashboardAPI.Controllers
{
    public class ProjectsController : Controller
    {

        [HttpGet]
        [Route("api/projects")]
        public List<Project> Get()
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            List<Project> projects = dbContext.Projects.ToList();
            return projects;
            //return View();
        }

        [HttpPost]
        [Route("api/projects")]
        public Project Post(Project p)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            dbContext.Projects.Add(p);
            dbContext.SaveChanges();
            return p;
        }
    }
}
