using System.ComponentModel.DataAnnotations;

namespace ToDoList.DTO
{
    public class AssignmentReadDTO
    {
        public int TaskId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserName { get; set; } = null!; // Ім'я користувача
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }


}
