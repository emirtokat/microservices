namespace TaskService.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public string AssignedTo { get; set; }
    }
}
