using ToDoList.DTO;

namespace ToDoList.Interfaces
{
    public interface ITaskService
    {
        List<AssignmentReadDTO> GetAllTasks();
        Task<AssignmentReadDTO> GetTaskById(int taskId);
        Task<AssignmentReadDTO> CreateTask(AssignmentCreateDTO newTask);
        Task<AssignmentReadDTO> UpdateTask(AssignmentUpdateDTO newTask);
        Task<List<AssignmentSummaryDTO>> GetShortInformation();
        Task DeleteTask(int taskId);
    }

}
