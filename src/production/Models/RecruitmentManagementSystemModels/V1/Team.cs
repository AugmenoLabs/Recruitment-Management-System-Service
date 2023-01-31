﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentManagementSystemModels.V1
{
    public class Team
    {
        [Key]
        [Required]
        public string TeamID { get; set; }


        [Required]
        public string TeamName { get; set; }

        public string TeamDetails { get; set; }

        [Required]
        public string AccountID { get; set; }
    }
}
