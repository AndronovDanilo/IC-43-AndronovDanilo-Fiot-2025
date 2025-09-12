using MyHotelDomain.Models;
using MongoDB.Driver;

namespace MyHotelInfrastructure.Service;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;

    public UserService(MongoDbService mongoDbService)
    {
        _usersCollection = mongoDbService.GetCollection<User>("users");
    }
}