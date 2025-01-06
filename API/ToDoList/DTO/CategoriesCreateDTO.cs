namespace ToDoList.DTO
{
    public class CategoriesCreateDTO
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public int UserId { get; set; }

    }
}
