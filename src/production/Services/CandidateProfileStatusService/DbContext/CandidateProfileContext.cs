using CandidateProfileStatusService.Models;
using Microsoft.EntityFrameworkCore;

namespace CandidateProfileStatusService
{
    public class CandidateProfileContext : DbContext
    {
        public CandidateProfileContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CandidateProfile>(entity =>
            {
                entity.HasIndex(e => e.CandidateID).IsUnique();
            });
        }

        public DbSet<CandidateProfile> CandidateProfiles { get; set; } 
    }
}
