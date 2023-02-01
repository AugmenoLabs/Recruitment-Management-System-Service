using System.ComponentModel.DataAnnotations;

namespace RecruitmentManagementSystemModels.V1
{
    public class CandidateProfile
    {
        [Key]
        [Required]
        public string CandidateID { get; set; }

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
        public string YearOfExperience { get; set; }

        [Required]
        public string PrimarySkills { get; set; } 
        
        public string SecondarySkills { get; set; }

        [Required]
        public long JobID { get; set; }

        public string CurrentCTC { get; set; }

        public string ExpectedCTC { get; set; }

        public string NoticePeriod { get; set; }

        public bool HasOfferLetter { get; set; }

    }
}
