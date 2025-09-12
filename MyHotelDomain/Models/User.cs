using MongoDB.Bson.Serialization.Attributes; 

namespace MyHotelDomain.Models;

public class User : Entity
{
    [BsonElement("login")]
    public string? Login { get; set; }
    [BsonElement("password")]
    public string? Password { get; set; }
    [BsonElement("email")]
    public string? Email { get; set; }
    [BsonElement("role")]
    public string? Role { get; set; }
}