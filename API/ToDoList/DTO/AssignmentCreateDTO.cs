namespace ToDoList.DTO
{
    public class AssignmentCreateDTO
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int UserId { get; set; }
        //public int? CategoryId { get; set; }
    }
}
