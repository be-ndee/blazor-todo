using blazor_todo.Models;

namespace blazor_todo.Services;

public class SessionService
{
    private User? user;

    public void Login(User loginUser)
    {
        user = loginUser;
    }

    public User? GetUser()
    {
        return user;
    }
}