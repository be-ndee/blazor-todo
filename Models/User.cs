using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace blazor_todo.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]

    public string? Id { get; set; }

    public string Username { get; set; }
}
