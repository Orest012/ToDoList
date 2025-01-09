using Microsoft.AspNetCore.Mvc;
using ToDoList.DTO;
using ToDoList.Models;

namespace ToDoList.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> AddCategory(CategoriesCreateDTO newCategory);
        List<Category> GetAllCategories();
        Task DeleteCategory(int id);
    }
}
