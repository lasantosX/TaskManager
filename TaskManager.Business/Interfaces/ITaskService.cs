using TaskManager.Business.Dtos;
using TaskManager.Domain.Models;

namespace TaskManager.Business.Interfaces;

public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetTasksAsync();

    Task<TaskItem?> GetTaskByIdAsync(int id);

    Task<TaskItem> CreateTaskAsync(CreateTaskRequest request);
}