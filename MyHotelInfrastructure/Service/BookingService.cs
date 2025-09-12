    using MyHotelDomain.Models;
    using MongoDB.Driver;

    namespace MyHotelInfrastructure.Service;

    public class BookingService
    {
        private readonly IMongoCollection<Booking> _bookingsCollection;

        public BookingService(MongoDbService mongoDbService)
        {
            _bookingsCollection = mongoDbService.GetCollection<Booking>("bookings");
        }
    }