using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class Account: BaseClass
    {
        [Key]
        public Guid AccountId { get; set; }

        [Required]
        public string AccountName { get; set; }

        public string AccountDetail { get; set; }

        public string AccountManager { get; set; }
    }
}
