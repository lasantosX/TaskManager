using TaskManager.Business.Dtos;
using TaskManager.Business.Interfaces;
using TaskManager.Data.Interfaces;
using TaskManager.Domain.Constants;
using TaskManager.Domain.Models;

namespace TaskManager.Business.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<IEnumerable<TaskItem>> GetTasksAsync()
    {
        return await _taskRepository.GetAllAsync();
    }

    public async Task<TaskItem?> GetTaskByIdAsync(int id)
    {
        return await _taskRepository.GetByIdAsync(id);
    }

    public async Task<TaskItem> CreateTaskAsync(CreateTaskRequest request)
    {
        var task = new TaskItem
        {
            Title = request.Title,
            Description = request.Description,
            Status = TaskStatuses.Pending,
            CreatedAt = DateTime.UtcNow
        };

        return await _taskRepository.AddAsync(task);
    }
}