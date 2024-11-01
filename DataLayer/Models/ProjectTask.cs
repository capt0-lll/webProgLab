namespace DataLayer.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public long ProjectId { get; set; }
        public long EmployeeId { get; set; }
        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
