using blazor_todo.Models;

namespace blazor_todo.Services;

public class UserService(IConfiguration configuration, HttpClient httpClient)
{
    private HttpClient Http { get; set; } = httpClient;
    private readonly string serviceEndpoint = $"{configuration.GetValue<string>("BackendUrl")}/Users";

    public Task<List<User>?> GetAllAsync() => Http.GetFromJsonAsync<List<User>>(serviceEndpoint);

    // TODO replace by call with filter
    public async Task<User?> GetByUsernameAsync(string username) => (await GetAllAsync())?.Find(user => user.Username == username) ?? null;

    public Task CreateAsync(User user) => Http.PostAsJsonAsync(serviceEndpoint, user);
}