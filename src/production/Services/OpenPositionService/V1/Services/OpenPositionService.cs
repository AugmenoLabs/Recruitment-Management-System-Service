using Microsoft.EntityFrameworkCore;
using OpenPositionService.V1.Helpers;
using OpenPositionService.V1.Interfaces;
using OpenPositionService.V1.Models;

namespace OpenPositionService.V1.Services
{
    public class OpenPositionService : IOpenPositionService
    {
        private readonly RecruitmentMgmtDbContext _context;

        public OpenPositionService(RecruitmentMgmtDbContext context)
        {
            _context = context;
        }

        public OpenPositionService()
        {
        }

        public IEnumerable<OpenPosition> GetAllOpenPositions()
        {
            return _context.OpenPositions;
        }

        public OpenPosition GetOpenPositionById(int id)
        {
            return getOpenPosition(id);
        }

        public void CreateOpenPositions(OpenPosition job)
        {
            //Validate
            if(_context.OpenPositions.Any(x => x.JobId == job.JobId))
            {
                throw new AppException("Job With JobId '" + job.JobId + "' already exists");
            }
            _context.OpenPositions.Add(job);
            _context.SaveChanges();
        }

        public void UpdateOpenPositions(int id, OpenPosition job)
        {
            var jobOpening = getOpenPosition(id);

            if (job.JobId != jobOpening.JobId && _context.OpenPositions.Any(x => x.JobId == job.JobId))
                throw new AppException("Job With JobId '" + job.JobId + "' already exists");
            _context.OpenPositions.Update(jobOpening);
            _context.SaveChanges();
        }

        public void DeleteOpenPosition(int id)
        {
            var jobOpening = getOpenPosition(id);
            _context.OpenPositions.Remove(jobOpening);
            _context.SaveChanges();
        }

        private OpenPosition getOpenPosition(int id)
        {
            var openPosition = _context.OpenPositions.Find(id);
            if (openPosition == null) throw new KeyNotFoundException("Open Position Not Found");
            return openPosition;
        }
    }
}
