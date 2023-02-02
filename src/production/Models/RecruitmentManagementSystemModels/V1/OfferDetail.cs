using System.ComponentModel.DataAnnotations;

namespace RecruitmentManagementSystemModels.V1
{
    public class OfferDetail
    {
        [Key]
        public int OfferId { get; set; }

        public string CandidateId { get; set; }

        [Required]
        public long JobId { get; set; }

        public string CompanyName { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }

        public string OfferedCTC { get; set; }
    }
}
