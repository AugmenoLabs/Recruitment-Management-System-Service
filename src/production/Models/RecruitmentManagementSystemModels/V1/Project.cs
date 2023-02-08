using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystemModels.V1
{
    public class Project: BaseClass
    {
        [Key]
        public Guid ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        public string ProjectDetails { get; set; }

        [Required]
        public string ProjectManager { get; set; }

        [Display(Name = "Account")]
        public virtual Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
