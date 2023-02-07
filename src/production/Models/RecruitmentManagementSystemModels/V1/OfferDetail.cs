﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystemModels.V1
{
    public class OfferDetail
    {
        [Key]
        public Guid OfferId { get; set; }

        [Display(Name ="CandidateProfile")]
        public virtual string CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual CandidateProfile CandidateProfile { get; set; }

        [Display(Name = "OpenPosition")]
        public virtual Guid Id { get; set; }

        [ForeignKey("Id")]
        public virtual OpenPosition OpenPosition { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string OfferedCTC { get; set; }
    }
}
