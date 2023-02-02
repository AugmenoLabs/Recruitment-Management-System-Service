

namespace RecruitmentManagementSystemModels.V1
{
    public class BaseClass
    {
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
