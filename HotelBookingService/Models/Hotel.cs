﻿using MongoDB.Bson.Serialization.Attributes;

namespace HotelBookingService.Models;

public class Hotel : Entity
{
    [BsonElement("name")]
    public string? Name { get; set; }
    [BsonElement("address")]
    public string? Address {get; set;}
    [BsonElement("describe")]
    public string? Describe { get; set;}
    [BsonElement("rate")]
    public float? Rate { get; set;}
}