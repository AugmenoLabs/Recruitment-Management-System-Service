using OpenPositionService.V1.Models;

namespace OpenPositionService.V1.Interfaces
{
    public interface IOpenPositionService
    {
        IEnumerable<OpenPosition> GetAllOpenPositions();
        OpenPosition GetOpenPositionById(int id);
        void CreateOpenPositions(OpenPosition job);
        void UpdateOpenPositions(int id, OpenPosition job);
        void DeleteOpenPosition(int id);
    }
}
