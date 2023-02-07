using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace RecruitmentManagementSystemModels.V1
{
    public class ProfileStatus
    {
        public long Id { get; set; }

        [Display(Name = "CandidateProfile")]
        public virtual string CandidateId { get; set; }

        [ForeignKey("CandidateId")]
        public virtual CandidateProfile CandidateProfile { get; set; }

        [Display(Name = "OpenPosition")]
        public virtual long JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual OpenPosition OpenPosition { get; set; }

        public string InterviewStatus { get; set; } //Pending, Assigned, Done

        public string InterviewRound { get; set; } //1st Techincal, 2nd Technical or HR 

        public string Interviewer { get; set; } //Name of the person going to take interview

        public string CandidateContactNumber { get; set; }
    }
}
