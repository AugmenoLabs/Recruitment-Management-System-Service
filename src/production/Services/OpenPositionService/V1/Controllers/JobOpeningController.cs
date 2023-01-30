using OpenPositionService.V1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenPositionService.V1.Interfaces;

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
        public IActionResult GetOpenPositionById(int id)
        {
            var jobOpening = _openPositionService.GetOpenPositionById(id);
            return Ok(jobOpening);
        }

        [HttpPost]
        public IActionResult CreateOpenPositions(OpenPosition job)
        {
            _openPositionService.CreateOpenPositions(job);
            return Ok(new { message = "JobPosition Created" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOpenPosition(int id, OpenPosition job)
        {
            _openPositionService.UpdateOpenPositions(id, job);
            return Ok(new { message = "JobPosition Updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOpenPosition(int id)
        {
            _openPositionService.DeleteOpenPosition(id);
            return Ok(new { message = "User Deleted" });
        }
    }
}
//JobId, Title,Location,NoOfOpenings,MinimumExperience,JobDescription,SkillsRequired,PostedOn,PostedBy