using blazor_todo.Models;

namespace blazor_todo.Services;

public class TodoService(IConfiguration configuration, HttpClient httpClient)
{
    private HttpClient Http { get; set; } = httpClient;
    private readonly string serviceEndpoint = $"{configuration.GetValue<string>("BackendUrl")}/TodoItems";


    public Task<List<TodoItem>?> GetListAsync() => Http.GetFromJsonAsync<List<TodoItem>>(serviceEndpoint);

    public Task CreateAsync(TodoItem todoItem) => Http.PostAsJsonAsync(serviceEndpoint, todoItem);
}