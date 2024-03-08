using blazor_todo.Models;

namespace blazor_todo.Services
{
    public class TodoService
    {
        private List<TodoItem> todos = new List<TodoItem>([]);
        public List<TodoItem> GetList()
        {
            return todos;
        }

        public void Add(TodoItem todoItem)
        {
            todos.Add(todoItem);
        }
    }
}

