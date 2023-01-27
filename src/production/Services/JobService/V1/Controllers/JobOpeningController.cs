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
        public async Task<IActionResult> GetJobOpenings()
        {
            return Ok(await _context.jobs.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddJobOpenings(Job job)
        {
            _context.jobs.Add(job);
            await _context.SaveChangesAsync();
            return Created($"/get-job-by-id?id={job.JobId}",job);
        }

        [HttpGet("{id}", Name = "GetJob")]
        public async Task<IActionResult> GetJobOpening(string id)
        {
            var job = await _context.jobs.FindAsync(id);
            if (job == null) return NotFound();
            return Ok(job);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateJobOpening(Job job)
        {
            _context.jobs.Update(job);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteJob")]
        public async Task<IActionResult> DeleteJobOpenings(string id)
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