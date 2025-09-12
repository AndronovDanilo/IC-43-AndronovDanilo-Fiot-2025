using MyHotelDomain.Models;
using MongoDB.Driver;

namespace MyHotelInfrastructure.Service;

public class HotelService
{
    private readonly IMongoCollection<Hotel> _hotelsCollection;

    public HotelService(MongoDbService mongoDbService)
    {
        _hotelsCollection = mongoDbService.GetCollection<Hotel>("hotels");
    }
}