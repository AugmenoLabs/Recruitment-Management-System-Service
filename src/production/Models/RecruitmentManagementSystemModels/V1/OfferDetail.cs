using System.ComponentModel.DataAnnotations;

namespace RecruitmentManagementSystemModels.V1
{
    public class OfferDetail
    {
        [Key]
        [Required]
        public string CandidateID { get; set; }

        [Required]
        public string JobID { get; set; }

        public string OfferedCompanyName { get; set; }

        [Required]
        public DateTime DateOfJoining { get; set; }

        public string OfferedCTC { get; set; }
    }
}
