using MongoDB.Bson.Serialization.Attributes;

namespace M220N.Models
{
    public class Session
    {
        public string Jwt { get; set; }

        [BsonElement("user_id")]
        public string UserId { get; set; }
    }
}