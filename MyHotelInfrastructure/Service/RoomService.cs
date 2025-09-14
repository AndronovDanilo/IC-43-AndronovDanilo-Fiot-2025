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
    public async Task<List<Room>> GetAsync() =>
        await _roomsCollection.Find(_ => true).ToListAsync();

    public async Task<Room?> GetAsync(string id) =>
        await _roomsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Room newRoom) =>
        await _roomsCollection.InsertOneAsync(newRoom);

    public async Task UpdateAsync(string id, Room updatedRoom) =>
        await _roomsCollection.ReplaceOneAsync(x => x.Id == id, updatedRoom);

    public async Task RemoveAsync(string id) =>
        await _roomsCollection.DeleteOneAsync(x => x.Id == id);
}
