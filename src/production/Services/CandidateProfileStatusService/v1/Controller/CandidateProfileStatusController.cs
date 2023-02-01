using CandidateProfileStatusService.v1.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RecruitmentManagementSystemModels.V1;

namespace CandidateProfileStatusService.v1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateProfileStatusController : ControllerBase
    {
        private ICandidateProfileStatusService _CandidateProfileStatusService;

        public CandidateProfileStatusController(ICandidateProfileStatusService candidateProfileStatusService)
        {
            _CandidateProfileStatusService = candidateProfileStatusService;
        }

        [HttpGet]
        public IActionResult GetAllCandidateProfile()
        {
            var candidateProfiles = _CandidateProfileStatusService.GetAllCandidateProfile();
            return Ok(candidateProfiles);
        }

        [HttpGet("{id}")]
        public IActionResult GetCandidateProfileById(string id)
        {
            var candidateProfile = _CandidateProfileStatusService.GetCandidateById(id);
            return Ok(candidateProfile);
        }

        [HttpPost]
        public IActionResult CreateCandidateProfile(CandidateProfile candidate)
        {
            _CandidateProfileStatusService.CreateCandidateProfile(candidate);
            return Ok(new { message = "Candidate Profile Created" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCandidateProfile(string id, CandidateProfile candidate)
        {
            _CandidateProfileStatusService.UpdateCandidateProfile(id, candidate);
            return Ok(new { message = "Candidate Profile Updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCandidateProfile(string id)
        {
            _CandidateProfileStatusService.DeleteCandidateProfile(id);
            return Ok(new { message = "Profile Deleted" });
        }
    }
}

