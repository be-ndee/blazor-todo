using blazor_todo.Models;

namespace blazor_todo.Services
{
    public class SessionService
    {
        private User user;

        public void Login(string username)
        {
            user = new User{Username = username};
        }

        public User GetUser()
        {
            return user;
        }
    }
}

