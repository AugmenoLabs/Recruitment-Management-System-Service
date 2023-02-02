using System.ComponentModel.DataAnnotations;

namespace RecruitmentManagementSystemModels.V1
{
    public class CandidateProfile : BaseClass
    {
        [Key]
        public string CandidateId { get; set; }

        [Required]
        public string CandidateName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public long ContactNumber { get; set; }

        public string ResidentialAddress { get; set; }

        public string PermanenetAddress { get; set; }

        [Required]
        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        [Required]
        public int YearOfExperience { get; set; }

        [Required]
        public string PrimarySkills { get; set; }

        public string SecondarySkills { get; set; }

        [Required]
        public long JobId { get; set; }

        public long CurrentCTC { get; set; }

        public long ExpectedCTC { get; set; }

        public string NoticePeriod { get; set; }

        public bool HasOfferLetter { get; set; }

    }
}
