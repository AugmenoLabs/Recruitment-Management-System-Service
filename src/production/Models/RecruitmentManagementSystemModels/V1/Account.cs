using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagementSystemModels.V1
{
    public class Account
    {
        [Key]
        [Required]
        public string AccountID { get; set; }

        [Required]
        public string AccountName { get; set; }

        public string AccountDetails { get; set; }
    }
}
