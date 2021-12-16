namespace PsychologicalAssistance.Core.Data.DTOs
{
    public class FullConsultingApplicationDto : ConsultingApplicationDto
    {
        public string UserId { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
    }
}