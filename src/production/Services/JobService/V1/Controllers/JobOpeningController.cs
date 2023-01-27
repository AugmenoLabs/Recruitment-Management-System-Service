using OpenPositionService.V1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace OpenPositionService.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOpeningController : Controller
    {
        private readonly RecruitmentMgmtDbContext _context;

        public JobOpeningController(RecruitmentMgmtDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOpenPositions()
        {
            return Ok(await _context.openPositions.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddOpenPositions(OpenPosition job)
        {
            _context.openPositions.Add(job);
            await _context.SaveChangesAsync();
            return Created($"/get-job-by-id?id={job.JobId}", job);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetOpenPosition([FromRoute] Guid id)
        {
            var job = await _context.openPositions.FindAsync(id);
            if (job == null) return NotFound();
            return Ok(job);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOpenPosition(OpenPosition job)
        {
            _context.openPositions.Update(job);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteOpenPosition([FromRoute] Guid id)
        {
            var job = await _context.openPositions.FindAsync(id);
            if (job != null)
            {
                _context.Remove(job);
                _context.SaveChanges();
                return Ok(job);
            }
            return NotFound();
        }
    }
}
//JobId, Title,Location,NoOfOpenings,MinimumExperience,JobDescription,SkillsRequired,PostedOn,PostedBy