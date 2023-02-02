using AccountManagementService.V1.Interface;
using OpenPositionService;
using OpenPositionService.V1.Helpers;
using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Service
{
    public class ProjectService : IProjectService
    {
        private readonly RecruitmentMgmtSystemDbContext _context;

        public ProjectService(RecruitmentMgmtSystemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _context.Projects;
        }

        public Project GetProjectById(string id)
        {
            return GetProject(id);
        }

        public void CreateProjects(Project project)
        {
            //Validate
            if (_context.Projects.Any(x => x.ProjectId == project.ProjectId))
            {
                throw new AppException("Project With ProjectId '" + project.ProjectId + "' already exists");
            }
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void UpdateProjects(string id, Project project)
        {
            var proj = GetProject(id);

            if (project.ProjectId != proj.ProjectId && _context.Projects.Any(x => x.ProjectId == project.ProjectId))
                throw new AppException("Project With ProjectId '" + project.ProjectId + "' already exists");

            proj.ProjectId= project.ProjectId;
            proj.ProjectName= project.ProjectName;
            proj.ProjectDetails= project.ProjectDetails;
            proj.ProjectManager = project.ProjectManager;
            proj.AccountId = project.AccountId;
            _context.Projects.Update(proj);
            _context.SaveChanges();
        }


        public void DeleteProject(string id)
        {
            var acc = GetProject(id);
            _context.Projects.Remove(acc);
            _context.SaveChanges();
        }

        private Project GetProject(string id)
        {
            var project = _context.Projects.Find(id);
            if (project == null) throw new KeyNotFoundException("Project Not Found");
            return project;
        }

    }
}
