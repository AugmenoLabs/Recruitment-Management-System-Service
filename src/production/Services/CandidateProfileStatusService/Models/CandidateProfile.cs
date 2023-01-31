using System.ComponentModel.DataAnnotations;

namespace CandidateProfileStatusService.Models
{
    public class CandidateProfile
    {
        [Key]
        public string candidateID { get; set; }

        [Required]
        public string candidateName { get; set; }
        
        [Required]
        public string candidateEmail { get; set; }

        [Required]
        public string candidateContactNumber { get; set; }

        public string candidateCurrenAddress { get; set; }

        public string candidatePermanenetAddress { get; set; }

        [Required]
        public string gender { get; set; }

        public string maritalStatus { get; set; }

        [Required]
        public string YearOfExperience { get; set; }

        [Required]
        public string primarySkills { get; set; } 
        
        public string secondarySkills { get; set; }

        [Required]
        public long jobID { get; set; }

        public string currentCTC { get; set; }

        public string expectedCTC { get; set; }

        public string noticePeriod { get; set; }

    }
}
