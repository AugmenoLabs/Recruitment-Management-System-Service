using RecruitmentManagementSystemModels.V1;

namespace CandidateProfileStatusService.v1.Interfaces
{
    public interface ICandidateProfileStatusService
    {
        IEnumerable<CandidateProfile> GetAllCandidateProfile();
        CandidateProfile GetCandidateById(string id);
        void CreateCandidateProfile(CandidateProfile Candidate);
        void UpdateCandidateProfile(string id, CandidateProfile Candidate);
        void DeleteCandidateProfile(string id);
    }
}
