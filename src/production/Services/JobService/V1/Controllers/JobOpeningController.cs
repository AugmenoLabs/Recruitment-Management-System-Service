using JobService.V1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobService.V1.Controllers
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
        public async Task<IActionResult> GetJobs()
        {
            return Ok(await _context.jobs.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddJobs(Job job)
        {
            _context.jobs.Add(job);
            await _context.SaveChangesAsync();
            return Created($"/get-job-by-id?id={job.JobId}",job);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetJob([FromRoute] Guid id)
        {
            var job = await _context.jobs.FindAsync(id);
            if (job == null) return NotFound();
            return Ok(job);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateJob(Job job)
        {
            _context.jobs.Update(job);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteJobs([FromRoute] Guid id)
        {
            var job = await _context.jobs.FindAsync(id);
            if(job != null)
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