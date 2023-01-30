using OpenPositionService.V1.Models;
using Microsoft.EntityFrameworkCore;


namespace OpenPositionService
{
    public class RecruitmentMgmtDbContext : DbContext
    {
        public RecruitmentMgmtDbContext(DbContextOptions<RecruitmentMgmtDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OpenPosition>(entity =>
            {
                entity.HasIndex(e => e.JobTitle).IsUnique();

            });
        }

        public DbSet<OpenPosition> OpenPositions { get; set; }
    }

}
