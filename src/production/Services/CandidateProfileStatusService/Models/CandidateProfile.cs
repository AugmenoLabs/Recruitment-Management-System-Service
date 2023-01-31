﻿using System.ComponentModel.DataAnnotations;

namespace CandidateProfileStatusService.Models
{
    public class CandidateProfile
    {
        [Key]
        public string CandidateID { get; set; }

        [Required]
        public string CandidateName { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        public string CurrenAddress { get; set; }

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

    }
}
