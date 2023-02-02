using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Interface
{
    public interface IProjectService
    { 
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(string id);
        void CreateProjects(Project project);
        void UpdateProjects(string id, Project project);
        void DeleteProject(string id);
    }
}
