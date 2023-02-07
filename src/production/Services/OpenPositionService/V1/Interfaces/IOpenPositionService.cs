
using RecruitmentManagementSystemModels.V1;

namespace OpenPositionService.V1.Interfaces
{
    public interface IOpenPositionService
    {
        IEnumerable<OpenPosition> GetAllOpenPositions();
        OpenPosition GetOpenPositionById(Guid id);
        void CreateOpenPositions(OpenPosition job);
        void UpdateOpenPositions(Guid id, OpenPosition job);
        void DeleteOpenPosition(Guid id);
    }
}
