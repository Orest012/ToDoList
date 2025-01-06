using ToDoList.Data;
using ToDoList.Interfaces;

namespace ToDoList.Services
{
    public class AccountService : IAccountService
    {
        public readonly AppDbContext _dbContext;
        public AccountService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Register(string Email, string firstName, string Password)               
        {

        }
    }
}
