
using Microsoft.EntityFrameworkCore;
using RecruitmentManagementSystemModels.V1;

namespace OpenPositionService
{
    public class RecruitmentMgmtSystemDbContext : DbContext
    {
        public RecruitmentMgmtSystemDbContext(DbContextOptions<RecruitmentMgmtSystemDbContext> options) : base(options)
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

        public DbSet<CandidateProfile> CandidateProfiles { get; set; }

        public DbSet<OfferDetail> OfferDetails { get; set; }

    }

}
