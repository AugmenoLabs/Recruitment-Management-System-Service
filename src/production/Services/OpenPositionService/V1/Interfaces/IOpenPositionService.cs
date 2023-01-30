using OpenPositionService.V1.Models;

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
