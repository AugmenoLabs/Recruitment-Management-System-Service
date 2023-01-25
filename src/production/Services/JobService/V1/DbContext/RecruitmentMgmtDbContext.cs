using Microsoft.EntityFrameworkCore;


namespace JobService
{
    public class RecruitmentMgmtDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public RecruitmentMgmtDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }

}
