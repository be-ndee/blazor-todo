using blazor_todo.Models;

namespace blazor_todo.Services
{
    public class TodoService
    {
        private List<TodoItem> todos = new List<TodoItem>([]);
        public List<TodoItem> GetList(bool OnlyOpen = false)
        {
            if (OnlyOpen) {
                return todos.FindAll(todo => !todo.IsDone);
            }
            return todos;
        }

        public void Add(TodoItem todoItem)
        {
            todos.Add(todoItem);
        }
    }
}

