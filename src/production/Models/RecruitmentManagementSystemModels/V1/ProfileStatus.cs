namespace RecruitmentManagementSystemModels.V1
{
    public class ProfileStatus
    {
        public string CandidateId { get; set; }

        public long JobID { get; set; }

        public string InterviewStatus { get; set; } //Pending, Assigned, Done

        public string InterviewRound { get; set; } //1st Techincal, 2nd Technical or HR 

        public string InterviewerAssigned { get; set; } //Name of the person going to take interview

        public string CandidateContactNumber { get; set; }
    }
}
