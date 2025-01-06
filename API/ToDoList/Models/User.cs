using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } // ID користувача, первинний ключ

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; } = null!; // Унікальна електронна пошта

        [Required]
        [MaxLength(255)] // Обмеження на довжину пароля
        public string Password { get; set; } = null!; // Пароль (до 255 символів)

        [Required]
        [MaxLength(255)]
        public string Username { get; set; } = null!; // Унікальне ім’я користувача

        // Навігаційні властивості
        public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
