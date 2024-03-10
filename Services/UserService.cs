using blazor_todo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace blazor_todo.Services;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;

    public UserService(IOptions<DatabaseSettings> databaseSettings) {
        var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
        _usersCollection = mongoDatabase.GetCollection<User>(databaseSettings.Value.UsersCollectionName);
    }

    public async Task<List<User>> GetAllAsync() => await _usersCollection.Find(_ => true).ToListAsync();

    public async Task<User?> GetByIdAsync(string id) => await _usersCollection.Find(user => user.Id == id).FirstOrDefaultAsync();

    public async Task<User?> GetByUsernameAsync(string username) => await _usersCollection.Find(user => user.Username == username).FirstOrDefaultAsync();

    public async Task CreateAsync(User newUser) => await _usersCollection.InsertOneAsync(newUser);

    public async Task UpdateAsync(string id, User updateUser) => await _usersCollection.ReplaceOneAsync(user => user.Id == id, updateUser);

    public async Task RemoveAsync(string id) => await _usersCollection.DeleteOneAsync(user => user.Id == id);
}