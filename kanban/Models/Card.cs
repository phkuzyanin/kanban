using System.ComponentModel.DataAnnotations;

namespace Kanban.Models;


public class Card
{
    public int Id { get; set; } //id задачи обязательно для заполнения
    [Required]
    public string Title { get; set; } //заголовок задачи, обязательно для заполнения
    public string? Content { get; set; } //содержание задачи
    public DateTime CreationDate { get; set; }//время создания задачи
    public DateTime DueDate { get; set; } //время окончания задачи
    //public int ColumnId { get; set; }
    //public virtual Column Column { get; set; }
    
    protected Card(){}  //конструктор для EF

    public Card(string title, string content, DateTime dueDate)
    {

        Title = title ?? throw new ArgumentNullException(nameof(title));
        Content = content;
        CreationDate = DateTime.UtcNow;
        DueDate = dueDate;
    }

}