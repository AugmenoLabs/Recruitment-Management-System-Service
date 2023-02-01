using Microsoft.AspNetCore.Mvc;
using OpenPositionService.V1.Interfaces;
using RecruitmentManagementSystemModels.V1;

namespace OpenPositionService.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOpeningController : ControllerBase
    {
        private IOpenPositionService _openPositionService;

        public JobOpeningController(IOpenPositionService openPositionService)
        {
            _openPositionService = openPositionService;
        }

        [HttpGet]
        public IActionResult GetAllOpenPositions()
        {
            var jobOpenings = _openPositionService.GetAllOpenPositions();
            return Ok(jobOpenings);
        }

        [HttpGet("{id}")]
        public IActionResult GetOpenPositionById(long id)
        {
            var jobOpening = _openPositionService.GetOpenPositionById(id);
            return Ok(jobOpening);
        }

        [HttpPost]
        public IActionResult CreateOpenPositions(OpenPosition job)
        {
            job.JobId = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmss"));
            _openPositionService.CreateOpenPositions(job);
            return Ok(new { message = "JobPosition Created" });
        }


        [HttpPut("{id}")]
        public IActionResult UpdateOpenPosition(long id, OpenPosition job)
        {
            _openPositionService.UpdateOpenPositions(id, job);
            return Ok(new { message = "JobPosition Updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOpenPosition(long id)
        {
            _openPositionService.DeleteOpenPosition(id);
            return Ok(new { message = "User Deleted" });
        }
    }
}