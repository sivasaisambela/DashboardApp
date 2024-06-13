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


        [HttpGet]
        [Route("api/projects/search/{searchby}/{searchtext}")]
        public List<Project> Search(string searchBy,string searchText)
        {
            List<Project> projects = null;
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            if (searchBy != null && searchBy == "ProjectID")
            {
                projects= dbContext.Projects.Where(x=>x.ProjectID.ToString().Contains(searchText)).ToList();
            }
            else if(searchBy != null &&searchBy=="ProjectName")
            {
                projects=dbContext.Projects.Where(x=>x.ProjectName.Contains(searchText)).ToList();
            }
            else
            {
                projects=dbContext.Projects.Where(x=>x.TeamSize.ToString().Contains(searchText)).ToList();
            }
           
            return projects;
            //return View();
        }

        [HttpPost]
        [Route("api/projects")]
        public Project Post([FromBody] Project p)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            dbContext.Projects.Add(p);
            dbContext.SaveChanges();
            return p;
        }

        [HttpPut]
        [Route("api/projects")]
        public Project Put([FromBody] Project p)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            Project existingProject = dbContext.Projects.Where(x=>x.ProjectID==p.ProjectID).FirstOrDefault();
            if(existingProject != null)
            {
                existingProject.ProjectName = p.ProjectName;
                existingProject.TeamSize = p.TeamSize;
                dbContext.SaveChanges();
                return existingProject;
            }
            else
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("api/projects")]
        public int Delete(int ProjectId)
        {
            TaskManagerDbContext dbContext = new TaskManagerDbContext();
            Project existingProject = dbContext.Projects.Where(x => x.ProjectID == ProjectId).FirstOrDefault();
            if (existingProject != null)
            {
                dbContext.Remove(existingProject);
                dbContext.SaveChanges();
                return ProjectId;
            }
            else
            {
               return -1;
            }
        }


    }
}
