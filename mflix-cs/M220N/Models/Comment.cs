using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace M220N.Models
{
    public class Comment
    {
        public DateTime Date { get; set; }

        public string Email { get; set; }

        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("movie_id")]
        [JsonProperty("movie_id")]
        [JsonIgnore]
        public ObjectId MovieId { get; set; }

        public string Name { get; set; }
        public string Text { get; set; }
    }
}