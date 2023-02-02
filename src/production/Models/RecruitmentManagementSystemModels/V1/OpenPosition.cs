using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystemModels.V1
{
    public class OpenPosition : BaseClass
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JobId { get; set; }

        public string JobTitle { get; set; }

        public string AccountId { get; set; }

        public string ProjectId { get; set; }

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
