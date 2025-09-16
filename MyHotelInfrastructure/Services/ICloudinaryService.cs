using MyHotelDomain.Models;

namespace MyHotelInfrastructure.Services;

public interface ICloudinaryService
{
    Task<Photo> UploadPhotoAsync(Stream fileStream, string entityName, string entityId, int order);
    Task<bool> DeletePhotoAsync(string publicId);
}