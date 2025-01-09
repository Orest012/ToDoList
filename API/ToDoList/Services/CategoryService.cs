using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.DTO;
using ToDoList.Interfaces;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _dbContext;
        public CategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category> AddCategory([FromBody] CategoriesCreateDTO newCategory)
        {
            if (newCategory == null)
            {
                throw new ArgumentNullException();
            }


            var category = new Category
            {
                CategoryId = newCategory.CategoryId,
                CategoryName = newCategory.CategoryName,
                UserId = newCategory.UserId
            };
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategory(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            var category = _dbContext.Categories.FirstOrDefault(u => u.CategoryId == id);
            if (category == null)
            {
                throw new KeyNotFoundException($"Категорію з ID {id} не знайдено.");
            }

            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();
        }

        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories
                .Include(a => a.User)
                .Select(a => new Category
                {
                    CategoryId = a.CategoryId,
                    CategoryName = a.CategoryName,
                    UserId = a.UserId,
                })
                .ToList();
        }
    }
}
