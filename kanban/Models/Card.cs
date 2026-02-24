using System.ComponentModel.DataAnnotations;

namespace Kanban.Models;


public class Task
{
    [Required]
    public int Id { get; set; } //id задачи обязательно для заполнения
    [Required]
    public string? Title { get; set; } //заголовок задачи, обязательно для заполнения
    public string? Content { get; set; } //содержание задачи
    public DateTime CreationDate { get; set; }//время создания задачи
    public DateTime DueDate { get; set; } //время окончания задачи

    protected Task(){}  //конструктор для EF

    public Task(int id, string title, string content, DateTime dueDate)
    {
        Id = id;
        Title = title;
        Content = content;
        CreationDate = DateTime.UtcNow;
        DueDate = dueDate;
    }

};