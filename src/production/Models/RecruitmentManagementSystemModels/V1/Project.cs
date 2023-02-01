using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class Project
    {
        [Key]
        [Required]
        public string ProjectID { get; set; }


        [Required]
        public string ProjectName { get; set; }

        public string ProjectDetails { get; set; }

        public string ProjectManager { get; set; }


        [Required]
        public string AccountID { get; set; }
    }
}
