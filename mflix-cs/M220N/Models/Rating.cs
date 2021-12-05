using MongoDB.Bson.Serialization.Attributes;

namespace M220N.Models
{
    public class Rating
    {
        public int Meter { get; set; }

        public int NumReviews { get; set; }

        [BsonElement("rating")]
        public double RatingScore { get; set; }
    }
}