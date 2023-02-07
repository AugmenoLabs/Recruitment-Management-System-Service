using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string Qualification { get; set; }

        [Display(Name = "OpenPosition")]
        public virtual long JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual OpenPosition OpenPosition { get; set; }

        [Display(Name ="Vendor")]
        public virtual long VendorId { get; set; }

        [ForeignKey("VendorId")]
        public virtual Vendor Vendor { get; set; }

        public long CurrentCTC { get; set; }

        public long ExpectedCTC { get; set; }

        public string NoticePeriod { get; set; }

        public bool HasOfferLetter { get; set; }

    }
}
