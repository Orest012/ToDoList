namespace ToDoList.DTO
{
    public class AssignmentUpdateDTO
    {
        public int TaskId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public string? categoryName { get; set; }

    }
}
