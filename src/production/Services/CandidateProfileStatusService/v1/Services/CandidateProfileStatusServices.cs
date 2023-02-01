using CandidateProfileStatusService.v1.Interfaces;
using CandidateProfileStatusService.V1.Helpers;
using Microsoft.EntityFrameworkCore;
using OpenPositionService;
using RecruitmentManagementSystemModels.V1;

namespace CandidateProfileStatusService.v1.Services
{
    public class CandidateProfileStatusServices : ICandidateProfileStatusService
    {
        private readonly RecruitmentMgmtSystemDbContext _context;

        public CandidateProfileStatusServices(RecruitmentMgmtSystemDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CandidateProfile> GetAllCandidateProfile()
        {
            return _context.CandidateProfiles;
        }
        public CandidateProfile GetCandidateById(string id)
        {
            return getCandidateProfile(id);

        }
        public void CreateCandidateProfile(CandidateProfile Candidate)
        {
            if(_context.CandidateProfiles.Any(x => x.CandidateID == Candidate.CandidateID))
            {
                throw new AppException("Candidate with Candidate Id '"+ Candidate.CandidateID +"'already exists");
            }
            _context.CandidateProfiles.Add(Candidate);
            _context.SaveChanges();
        }
        public void UpdateCandidateProfile(string id, CandidateProfile Candidate)
        {
            var candidateProfile = getCandidateProfile(id);
            if ( candidateProfile == null ){
                throw new AppException("Candidate With CandidateId '" + Candidate.CandidateID + "' already exists");
            }

            _context.Entry(candidateProfile).State = EntityState.Modified;
            _context.CandidateProfiles.Update(candidateProfile);
                _context.SaveChanges();
        }
        public void DeleteCandidateProfile(string id)
        {
            var candidateprofile = getCandidateProfile(id);
            _context.CandidateProfiles.Remove(candidateprofile);
            _context.SaveChanges();
        }
        private CandidateProfile getCandidateProfile(string id)
        {
            var candidateprofile = _context.CandidateProfiles.Find(id);
            if (candidateprofile == null) throw new KeyNotFoundException("Candidate Not Found");
            return candidateprofile;
        }





    }
}
