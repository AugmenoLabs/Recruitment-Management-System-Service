using System.ComponentModel.DataAnnotations;

namespace CandidateProfileStatusService.Models
{
    public class HasOfferLetter
    {
        [Required]
        public string candidateID { get; set; }

        [Required]
        public string jobID { get; set; }

        public string offeredCompanyName { get; set; }

        [Required]
        public DateTime dateOfJoining { get; set; }

        public string offeredCTC { get; set; }
    }
}
