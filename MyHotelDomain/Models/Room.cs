﻿using MongoDB.Bson.Serialization.Attributes;

namespace MyHotelDomain.Models;

public class Room : Entity
{
    [BsonElement("number")]
    public int? Number { get; set; }
    [BsonElement("price")]
    public double? Price { get; set; }
    [BsonElement("capacity")]
    public int? Capacity {get; set;}
    [BsonElement("isfree")]
    public bool? IsFree {get; set;}
}