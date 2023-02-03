using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystemModels.V1
{
    public class OfferDetail
    {
        [Key]
        public int OfferId { get; set; }

        [Display(Name ="CandidateProfile")]
        public virtual string CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual CandidateProfile CandidateProfiles { get; set; }

        [Display(Name = "OpenPosition")]
        public virtual long JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual OpenPosition OpenPositions { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string OfferedCTC { get; set; }
    }
}
