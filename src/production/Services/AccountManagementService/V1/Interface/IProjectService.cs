using RecruitmentManagementSystemModels.V1;

namespace AccountManagementService.V1.Interface
{
    public interface IProjectService
    { 
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(Guid id);
        void CreateProjects(Project project);
        void UpdateProjects(Guid id, Project project);
        void DeleteProject(Guid id);
    }
}
