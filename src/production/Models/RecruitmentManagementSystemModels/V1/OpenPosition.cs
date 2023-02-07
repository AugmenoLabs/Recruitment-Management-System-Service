using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystemModels.V1
{
    public class OpenPosition : BaseClass
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public long JobId { get; set; }

        public string JobTitle { get; set; }

        [Display(Name ="Account")]
        public virtual string AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        [Display(Name = "Project")]
        public virtual string ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }    

        [Required]
        public string SkillSet { get; set; }

        [Required]
        public string YearOfExp { get; set; }

        public string? Qualification { get; set; }

        [Required]
        public string JobDescription { get; set; }


        public int NoOfPositions { get; set; }

        //County-State-City
        public string? Location { get; set; }

    }
}
