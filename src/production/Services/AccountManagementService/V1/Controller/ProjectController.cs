using AccountManagementService.V1.Interface;
using AccountManagementService.V1.Service;
using Microsoft.AspNetCore.Mvc;
using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Controller
{
    [Route("Api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }


        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var accounts = _projectService.GetAllProjects();
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public IActionResult GetProjectById(string id)
        {
            var account = _projectService.GetProjectById(id);
            return Ok(account);
        }

        [HttpPost]
        public IActionResult CreateProjects(Project project)
        {
            _projectService.CreateProjects(project);
            return Ok(new { message = "New Project Created" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProject(string str, Project project)
        {
            _projectService.UpdateProjects(str, project);
            return Ok(new { message = "Project Updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(string id)
        {
            _projectService.DeleteProject(id);
            return Ok(new { message = "Project Deleted" });
        }
    }
}
