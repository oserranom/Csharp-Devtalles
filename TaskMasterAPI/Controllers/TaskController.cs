using System;
using Microsoft.AspNetCore.Mvc;
using TaskMasterAPI.Models;
using TaskMasterAPI.Services;

namespace TaskMasterAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TaskController:ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Models.Task>> GetTasks()
    {
        return Ok(TaskDataStoreApi.Current.Tasks);
    }

    [HttpGet("{id}")]
    public ActionResult<Models.Task> GetTask(int id)
    {
        var task = TaskDataStoreApi.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound("La tarea no existe");
        }

        return Ok(task);
    }

    [HttpPost]
    public ActionResult<Models.Task> CreateTask(Models.TaskInsert taskInsert)
    {
        var newTask = new Models.Task
        {
            Id = TaskDataStoreApi.Current.Tasks.Max(t => t.Id + 1),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            IsCompleted = false,
            Title = taskInsert.Title,
            Description = taskInsert.Description
        };
        TaskDataStoreApi.Current.Tasks.Add(newTask);
        return Ok(newTask);
    }

    [HttpPut("{id}")]
    public ActionResult<Models.Task> UpdateTask(int id, Models.TaskInsert taskInsert)
    {
        var task = TaskDataStoreApi.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound("La tarea no existe");
        }

        task.Title = taskInsert.Title;
        task.Description = taskInsert.Description;
        task.UpdatedAt = DateTime.Now;

        return Ok(task);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTask(int id)
    {
        var task = TaskDataStoreApi.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound("La tarea no existe");
        }

        TaskDataStoreApi.Current.Tasks.Remove(task);
        return NoContent();
        
    }


}
