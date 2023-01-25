using JobService.V1.Models;
using Microsoft.EntityFrameworkCore;


namespace JobService
{
    public class RecruitmentMgmtDbContext : DbContext
    {
        public RecruitmentMgmtDbContext(DbContextOptions<RecruitmentMgmtDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Job>(entity => {
                entity.HasIndex(e => e.JobId).IsUnique();
                
            });
        }

        public DbSet<Job> Jobs { get; set; }
    }

}
