namespace VotingWorkshopBackend.Model
{
    public class WorkshopView
    {
        public int WorkshopRequestId { get; set; }
        public required string User { get; set; }
        public required string Saloon { get; set; }
        public required string Category { get; set; }
        public required string TimeslotStart { get; set; }
        public required string TimeslotEnd { get; set; }
        public required string Status { get; set; }
        public DateTime Date {  get; set; }
    }
}
