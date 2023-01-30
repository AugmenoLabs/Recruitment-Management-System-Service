using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenPositionService.V1.Models
{
    public class OpenPosition
    {
        public long JobId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string JobTitle { get; set; }

        [Required]
        public string SkillSet { get; set; }

        [Required]
        public string YearOfExp { get; set; }

        public string? Qualification { get; set; }

        [Required]
        public string JobDescription { get; set; }

        [Range(1, int.MaxValue)]
        public int NoOfPositions { get; set; }

        //County-State-City
        public string? Location { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime PostedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedOn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CreatedBy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string UpdatedBy { get; set; }

    }
}
