
using RecruitmentManagementSystemModels.V1;

namespace OpenPositionService.V1.Interfaces
{
    public interface IOpenPositionService
    {
        IEnumerable<OpenPosition> GetAllOpenPositions();
        OpenPosition GetOpenPositionById(long id);
        void CreateOpenPositions(OpenPosition job);
        void UpdateOpenPositions(long id, OpenPosition job);
        void DeleteOpenPosition(long id);
    }
}
