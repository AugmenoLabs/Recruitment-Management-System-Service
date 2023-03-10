using OpenPositionService.V1.Interfaces;
using RecruitmentManagementSystemModels.V1;
using OpenPositionService.V1.Helpers;

namespace OpenPositionService.V1.Services
{
    public class OpenPositionServices : IOpenPositionService
    {
        private readonly RecruitmentMgmtSystemDbContext _context;

        public OpenPositionServices(RecruitmentMgmtSystemDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OpenPosition> GetAllOpenPositions()
        {
            return _context.OpenPositions;
        }

        public OpenPosition GetOpenPositionById(Guid id)
        {
            return GetOpenPosition(id);
        }

        public void CreateOpenPositions(OpenPosition job)
        {
            //Validate
            if (_context.OpenPositions.Any(x => x.JobId == job.JobId))
            {
                throw new AppException("Job With JobId '" + job.JobId + "' already exists");
            }
            _context.OpenPositions.Add(job);
            _context.SaveChanges();
        }

        public void UpdateOpenPositions(Guid id, OpenPosition job)
        {
            var jobOpening = GetOpenPosition(id);

            if (job.Id != jobOpening.Id && _context.OpenPositions.Any(x => x.Id == job.Id))
                throw new AppException("Job With Id '" + job.Id + "' already exists");

            jobOpening.JobTitle = job.JobTitle;
            jobOpening.Location = job.Location;
            jobOpening.Qualification = job.Qualification;
            jobOpening.NoOfPositions = job.NoOfPositions;
            jobOpening.UpdatedOn = job.UpdatedOn;
            jobOpening.SkillSet = job.SkillSet;
            jobOpening.UpdatedBy = job.UpdatedBy;
            jobOpening.CreatedBy = job.CreatedBy;
            jobOpening.JobDescription = job.JobDescription;
            jobOpening.SkillSet = job.SkillSet;
            jobOpening.YearOfExp = job.YearOfExp;
           // jobOpening.PostedOn = job.PostedOn;

            _context.OpenPositions.Update(jobOpening);
            _context.SaveChanges();
        }
        //JobId, JobTitle, AccountName, TeamName, SkillSet, YearOfExp, Qualification, JobDescription, NoOfPositions, Location, PostedOn, UpdatedOn, CreatedBy, UpdatedBy
        public void DeleteOpenPosition(Guid id)
        {
            var jobOpening = GetOpenPosition(id);
            _context.OpenPositions.Remove(jobOpening);
            _context.SaveChanges();
        }

        private OpenPosition GetOpenPosition(Guid id)
        {
            var openPosition = _context.OpenPositions.Find(id);
            if (openPosition == null) throw new KeyNotFoundException("Open Position Not Found");
            return openPosition;
        }


    }
}
