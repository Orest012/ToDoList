namespace ToDoList.DTO
{
    public class AssignmentSummaryDTO
    {
        public int TaskId { get; set; }
        public string Title { get; set; } = null!;
        public bool? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
