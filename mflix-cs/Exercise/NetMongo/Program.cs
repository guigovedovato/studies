using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NetMongo
{
    internal static class Program
    {
        private static void Main()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://m220student:m220password@mflix.ivjwr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var db = client.GetDatabase("sample_mflix");
            var collection = db.GetCollection<BsonDocument>("movies");
            var result = collection.Find(new BsonDocument())
               .SortByDescending(m => m["runtime"])
               .Limit(10)
               .ToList();
            foreach (var r in result)
            {
                Console.WriteLine(r.GetValue("title"));
            }
        }
    }
}