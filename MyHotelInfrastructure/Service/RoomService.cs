using MyHotelDomain.Models;
using MongoDB.Driver;

namespace MyHotelInfrastructure.Service;

public class RoomService
{
    private readonly IMongoCollection<Room> _roomsCollection;

    public RoomService(MongoDbService mongoDbService)
    {
        _roomsCollection = mongoDbService.GetCollection<Room>("rooms");
    }
}