namespace blazor_todo.Models
{
    public class TodoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
}


