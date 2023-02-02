using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class Project: BaseClass
    {
        [Key]
        public string ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        public string ProjectDetails { get; set; }

        [Required]
        public string ProjectManager { get; set; }

        [Required]
        public string AccountId { get; set; }
    }
}
