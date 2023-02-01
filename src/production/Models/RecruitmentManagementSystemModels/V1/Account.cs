using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class Account
    {
        [Key]
        public string AccountID { get; set; }

        [Required]
        public string AccountName { get; set; }

        public string AccountDetails { get; set; }

        public string AccountManager { get; set; }
    }
}
