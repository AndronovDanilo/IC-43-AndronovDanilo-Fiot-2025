using MongoDB.Driver;
using MyHotelDomain.Models;
using Microsoft.Extensions.Options;
using MyHotelInfrastructure.Configuration;

namespace MyHotelInfrastructure.Service;

public class MongoDbService
{
    private readonly IMongoDatabase _database;

    public MongoDbService(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }
    public IMongoCollection<T> GetCollection<T>(string name)
    {
        return _database.GetCollection<T>(name);
    }
}