using Microsoft.EntityFrameworkCore;
using OpenPositionService.V1.Helpers;
using OpenPositionService.V1.Interfaces;
using OpenPositionService.V1.Models;

namespace OpenPositionService.V1.Services
{
    public class OpenPositionServices : IOpenPositionService
    {
        private readonly RecruitmentMgmtDbContext _context;

        public OpenPositionServices(RecruitmentMgmtDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OpenPosition> GetAllOpenPositions()
        {
            return _context.OpenPositions;
        }

        public OpenPosition GetOpenPositionById(long id)
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
        
        public void UpdateOpenPositions(long id, OpenPosition job)
        {
            var jobOpening = getOpenPosition(id);

            if (job.JobId != jobOpening.JobId && _context.OpenPositions.Any(x => x.JobId == job.JobId))
                throw new AppException("Job With JobId '" + job.JobId + "' already exists");
            _context.OpenPositions.Update(jobOpening);
            _context.SaveChanges();
        }

        public void DeleteOpenPosition(long id)
        {
            var jobOpening = getOpenPosition(id);
            _context.OpenPositions.Remove(jobOpening);
            _context.SaveChanges();
        }

        private OpenPosition getOpenPosition(long id)
        {
            var openPosition = _context.OpenPositions.Find(id);
            if (openPosition == null) throw new KeyNotFoundException("Open Position Not Found");
            return openPosition;
        }
    }
}
