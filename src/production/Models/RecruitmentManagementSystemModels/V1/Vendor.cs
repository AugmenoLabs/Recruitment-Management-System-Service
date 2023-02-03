using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class Vendor : BaseClass
    {
        [Key]
        public long VendorId { get; set; }

        [Required]
        public string VendorName { get; set; }
    }
}
