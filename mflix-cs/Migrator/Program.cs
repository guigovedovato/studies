using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M220N.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Migrator
{
    internal static class Program
    {
        private static readonly string mongoConnectionString = "mongodb+srv://<user>:<pass>@mflix.ivjwr.mongodb.net/sample_mflix";
        private static IMongoCollection<Movie> _moviesCollection;

        private static async Task Main()
        {
            Setup();

            Console.WriteLine("Starting the data migration.");

            Console.WriteLine("Getting dates.");
            var datePipelineResults = TransformDatePipeline();
            Console.WriteLine($"I found {datePipelineResults.Count} docs where the lastupdated field is of type 'string'.");

            if (datePipelineResults.Count > 0)
            {
                var listWrites = new List<WriteModel<Movie>>();

                datePipelineResults.ForEach(date =>
                    {
                        var filterDefinition = Builders<Movie>.Filter.Eq(m => m.Id, date.Id);

                        var pipeline = new[]
                        {
                            new BsonDocument("$addFields",
                                new BsonDocument("lastupdated",
                                    new BsonDocument("$dateFromString",
                                        new BsonDocument
                                        {
                                            {
                                                "dateString",
                                                new BsonDocument("$substr",
                                                    new BsonArray
                                                    {
                                                        "$lastupdated",
                                                        0,
                                                        23
                                                    })
                                            },
                                            {"timezone", "America/New_York"}
                                        })))
                        };
                        var updateDefinition = Builders<Movie>.Update.Pipeline(PipelineDefinition<Movie, Movie>.Create(pipeline));

                        listWrites.Add(new UpdateOneModel<Movie>(filterDefinition, updateDefinition));
                    }
                );

                Console.WriteLine("Processing dates.");
                BulkWriteResult<Movie> bulkWriteDatesResult = await _moviesCollection.BulkWriteAsync(listWrites, new BulkWriteOptions { IsOrdered = false });

                //var bulkWriteDatesResult = await _moviesCollection.BulkWriteAsync(
                //   datePipelineResults.Select(updatedMovie => new ReplaceOneModel<Movie>(
                //      new FilterDefinitionBuilder<Movie>().Where(m => m.Id == updatedMovie.Id),
                //      updatedMovie)));

                Console.WriteLine($"{bulkWriteDatesResult.ProcessedRequests.Count} records updated.");
            }

            Console.WriteLine("Getting imdb.rating.");
            var ratingPipelineResults = TransformRatingPipeline();
            Console.WriteLine($"I found {ratingPipelineResults.Count} docs where the imdb.rating field is not a number type.");

            if (ratingPipelineResults.Count > 0)
            {
                var listWrites = new List<WriteModel<Movie>>();

                ratingPipelineResults.ForEach(rating =>
                    {
                        var filterDefinition = Builders<Movie>.Filter.Eq(m => m.Id, rating.Id);

                        var pipeline = new[]
                        {
                            new BsonDocument("$addFields",
                                new BsonDocument("imdb.rating",
                                    new BsonDocument("$convert",
                                        new BsonDocument
                                        {
                                            {"input", "imdb.rating"},
                                            {"to", "double"},
                                            {"onError", -1}
                                        })))
                        };
                        var updateDefinition = Builders<Movie>.Update.Pipeline(PipelineDefinition<Movie, Movie>.Create(pipeline));

                        listWrites.Add(new UpdateOneModel<Movie>(filterDefinition, updateDefinition));
                    }
                );

                Console.WriteLine("Processing imdb.rating.");
                BulkWriteResult<Movie> bulkWriteRatingsResult = await _moviesCollection.BulkWriteAsync(listWrites, new BulkWriteOptions { IsOrdered = false });

                //var bulkWriteRatingsResult = await _moviesCollection.BulkWriteAsync(
                //   ratingPipelineResults.Select(updatedMovie => new ReplaceOneModel<Movie>(
                //      new FilterDefinitionBuilder<Movie>().Where(m => m.Id == updatedMovie.Id),
                //      updatedMovie)));

                Console.WriteLine($"{bulkWriteRatingsResult.ProcessedRequests.Count} records updated.");
            }

            Console.WriteLine();
            Console.WriteLine("Checking the data conversions...");
            Verify();

            // Keep the console window open until user hits `enter` or closes.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press <Enter> to close.");
            Console.ReadLine();
        }

        private static void Setup()
        {
            var mongoClient = new MongoClient(mongoConnectionString);

            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            _moviesCollection = mongoClient.GetDatabase("sample_mflix").GetCollection<Movie>("movies");
        }

        /// <summary>
        /// Creates an aggregation pipeline that finds all documents that have a string
        /// 'lastupdated' value and converts those values to type 'date'.
        ///
        /// The code below is the C# way to represent the following pipeline:
        ///
        /// [{'$match': {'lastupdated': {'$type': 2}}}, { '$addFields': {'lastupdated':
        /// {'$dateFromString': { 'dateString': {'$substr': ['$lastupdated', 0, 23]}}}}}] ///
        /// </summary>
        /// <returns>A List of Movie objects with the lastupdated values converted to dates.</returns>
        private static List<Movie> TransformDatePipeline()
        {
            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument("lastupdated",
                        new BsonDocument("$type", 2))),
                new BsonDocument("$addFields",
                    new BsonDocument("lastupdated",
                        new BsonDocument("$dateFromString",
                            new BsonDocument
                            {
                                {
                                    "dateString",
                                    new BsonDocument("$substr",
                                        new BsonArray
                                        {
                                            "$lastupdated",
                                            0,
                                            23
                                        })
                                },
                                {"timezone", "America/New_York"}
                            })))
            };

            return _moviesCollection
                .Aggregate(PipelineDefinition<Movie, Movie>.Create(pipeline))
                .ToList();
        }

        /// <summary>
        /// Creates an aggregation pipeline that finds all documents that have a non-numeric
        /// 'imdb.rating' value and converts those values to type 'double'.
        ///
        /// The code below is the C# way to represent the following pipeline:
        ///
        /// [{'$match': {'imdb.rating': {'$not': {'$type': 'number'}}}}, { '$addFields':
        /// {'imdb.rating': {'$convert': { 'input': 'imdb.rating', 'to': 'double', 'onError':
        /// -1}}}}] ///
        /// </summary>
        /// <returns>A List of Movie objects with the rating values converted.</returns>
        private static List<Movie> TransformRatingPipeline()
        {
            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument("imdb.rating",
                        new BsonDocument("$not",
                            new BsonDocument("$type", "number")))),
                new BsonDocument("$addFields",
                    new BsonDocument("imdb.rating",
                        new BsonDocument("$convert",
                            new BsonDocument
                            {
                                {"input", "imdb.rating"},
                                {"to", "double"},
                                {"onError", -1}
                            })))
            };

            return _moviesCollection
                .Aggregate(PipelineDefinition<Movie, Movie>.Create(pipeline))
                .ToList();
        }

        private static void Verify()
        {
            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument("$or",
                        new BsonArray
                        {
                            new BsonDocument("lastupdated",
                                new BsonDocument("$type", "string")),
                            new BsonDocument("imdb.rating",
                                new BsonDocument("$type", "string"))
                        })),
                new BsonDocument("$count", "badDocs")
            };

            var badDocs = _moviesCollection
                .Aggregate(PipelineDefinition<Movie, BsonDocument>.Create(pipeline))
                .ToList();

            if (badDocs.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[✓] No remaining docs to be converted. Great job!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ ] Uh oh. One or both of your pipelines missed {badDocs.Count} documents...");
            }
        }
    }
}